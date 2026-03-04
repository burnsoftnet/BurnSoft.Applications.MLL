using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class PrimerInventoryTests
    {
        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        /// <value>The test context.</value>
        public TestContext TestContext { get; set; }
        /// <summary>
        /// The error out
        /// </summary>
        private string _errOut;
        /// <summary>
        /// The database path
        /// </summary>
        private string _databasePath;
        /// <summary>
        /// The existing manu
        /// </summary>
        private string _existingManu;
        /// <summary>
        /// The existing name
        /// </summary>
        private string _existingName;
        /// <summary>
        /// The existing identifier
        /// </summary>
        private int _existingId;
        /// <summary>
        /// The manufacturer
        /// </summary>
        private string _manufacturer;
        /// <summary>
        /// The name
        /// </summary>
        private string _name;
        /// <summary>
        /// The qty
        /// </summary>
        private long _qty;
        /// <summary>
        /// The price
        /// </summary>
        private double _price;
        /// <summary>
        /// The primer type
        /// </summary>
        private int _primerType;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingManu = "CCI";
            _existingName = "CCI 200";
            _existingId = 1;
            _manufacturer = "White River";
            _name = "White River Small Pistol Primers";
            _qty = 1000;
            _price = 35.99;
            _primerType = 3;
        }

        private void AddTestDataExists()
        {
            if (!PrimerInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                PrimerInventory.Add(_databasePath, _manufacturer, _name, _primerType,
                    _price, _qty, out _);
            }
        }

        private void DeleteTestPowderExists()
        {
            if (PrimerInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                long id = PrimerInventory.GetId(_databasePath, _manufacturer, _name, out _);
                PrimerInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestPowder(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<PrimerListings> value = PrimerInventory.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerListingsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<PrimerListings> value = PrimerInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestPowderExists();
                bool value = PrimerInventory.Add(_databasePath, _manufacturer, _name, _primerType,
                    _price, _qty, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = PrimerInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerListingsData(PrimerInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestPowder();
                long id = PrimerInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = PrimerInventory.Update(_databasePath, id, _manufacturer, _name, _primerType,
                    _price, _qty - 500, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestPowder("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void UpdateQtyTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestPowder();
                long id = PrimerInventory.GetId(_databasePath, _manufacturer, _name, out _);
                List<PrimerListings> currentData = PrimerInventory.GetDetails(_databasePath, id, out _errOut);
                long currentQty = 0;
                double currentPrice = 0;
                double currentPricePerItem = 0;
                foreach (PrimerListings item in currentData)
                {
                    currentQty = item.Qty;
                    currentPrice = item.Price;
                    currentPricePerItem = item.PricePerPrimer;
                }

                bool value = PrimerInventory.UpdateQty(_databasePath, id, currentQty, currentPrice,
                    currentPricePerItem, 1200, 55.65, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestPowder("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = PrimerInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = PrimerInventory.Delete(_databasePath, id, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = PrimerInventory.Delete(_databasePath, _manufacturer, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = PrimerInventory.GetId(_databasePath, _existingManu, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"ID RETURNED {value}, expected {_existingId}");
                bAns = (value == _existingId);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<PrimerListings> value = PrimerInventory.GetDetails(_databasePath, _existingManu, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<PrimerListings> value = PrimerInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = PrimerInventory.DataExists(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = PrimerInventory.DataExists(_databasePath, _existingManu, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void CalculatePricePerItemTestRaw()
        {
            double value = PrimerInventory.CalculatePricePerItem(qty: 1000, price: 27.99);
            TestContext.WriteLine($"VALUE: {value}");
            bool bAns = (value == 0.02799);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Primers")]
        public void CalculatePricePerItemTestPoundsDollar()
        {
            double value = PrimerInventory.CalculatePricePerItem(qty: 1000, price: 27.99, useDollar: true);
            TestContext.WriteLine($"VALUE: {value}");
            bool bAns = (value == 0.03);
            General.HasTrueValue(bAns);
        }

    }
}
