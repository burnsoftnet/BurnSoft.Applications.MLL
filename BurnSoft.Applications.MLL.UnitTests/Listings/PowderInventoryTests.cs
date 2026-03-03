using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class PowderInventoryTests
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

        private double _weightInPounds;

        private double _price;

        private string _notes;

        
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingManu = "IMR Co.";
            _existingName = "IMR4227";
            _existingId = 3;
            _manufacturer = "Vihtavuori";
            _name = "Viht N320";
            _weightInPounds = 1;
            _notes = " ";
            _price = 20.95;
        }

        private void AddTestPowderExists()
        {
            if (!PowderInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                PowderInventory.Add(_databasePath, _manufacturer, _name,
                    _weightInPounds, _price, _notes, out _);
            }
        }

        private void DeleteTestPowderExists()
        {
            if (PowderInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                long id = PowderInventory.GetId(_databasePath, _manufacturer, _name, out _);
                PowderInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestPowder(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<PowderListing> value = PowderInventory.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.PowderListingData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<PowderListing> value = PowderInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PowderListingData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestPowderExists();
                bool value = PowderInventory.Add(_databasePath, _manufacturer, _name,
                    _weightInPounds, _price, _notes, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = PowderInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PowderListingData(PowderInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestPowderExists();
                PrintTestPowder();
                long id = PowderInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = PowderInventory.Update(_databasePath, id, _manufacturer, _name,
                    _weightInPounds, _price, "Great For Pistols", out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void UpdateQtyTest()
        {
            bool bAns = false;
            try
            {
                AddTestPowderExists();
                PrintTestPowder();
                long id = PowderInventory.GetId(_databasePath, _manufacturer, _name, out _);
                List<PowderListing> currentData = PowderInventory.GetDetails(_databasePath, id, out _errOut);
                double currentQty = 0;
                double currentGrains = 0;
                double currentPrice = 0;
                double currentPricePerItem = 0;
                foreach (PowderListing item in currentData)
                {
                    currentQty = item.WeightInPounds;
                    currentGrains = item.WeightInGrains;
                    currentPrice = item.Price;
                    currentPricePerItem = item.PricePerGrain;
                }

                bool value = PowderInventory.UpdateQty(_databasePath, id, currentQty, currentGrains, currentPrice, 
                    currentPricePerItem,8, 249.99, Enums.PowderWeightType.Pounds, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestPowderExists();
                long id = PowderInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = PowderInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestPowderExists();
                bool value = PowderInventory.Delete(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = PowderInventory.GetId(_databasePath, _existingManu, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<PowderListing> value = PowderInventory.GetDetails(_databasePath, _existingManu, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PowderListingData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<PowderListing> value = PowderInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PowderListingData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = PowderInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = PowderInventory.DataExists(_databasePath, _existingManu, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void CalculatePricePerItemTestPoundsRaw()
        {
            double value = PowderInventory.CalculatePricePerItem(weightValue: 1, price: 20.95,
                VolumeType: Enums.PowderWeightType.Pounds);
            TestContext.WriteLine($"VALUE: {value}");
            bool bAns = (value == 0.0029928614183734547);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void CalculatePricePerItemTestGrainsRaw()
        {
            double value = PowderInventory.CalculatePricePerItem(weightValue: 6999.99, price: 20.95,
                VolumeType: Enums.PowderWeightType.Grains);
            TestContext.WriteLine($"VALUE: {value}");
            General.HasTrueValue((value == 0.0029928614183734547));
        }

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void CalculatePricePerItemTestPoundsDollar()
        {
            double value = PowderInventory.CalculatePricePerItem(weightValue: 1, price: 20.95,
                VolumeType: Enums.PowderWeightType.Pounds, useDollar: true);
            TestContext.WriteLine($"VALUE: {value}");
            bool bAns = (value == 0.00);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Powder")]
        public void CalculatePricePerItemTestGrainsDollar()
        {
            double value = PowderInventory.CalculatePricePerItem(weightValue: 6999.99, price: 20.95,
                VolumeType: Enums.PowderWeightType.Grains, useDollar: true);
            TestContext.WriteLine($"VALUE: {value}");
            General.HasTrueValue((value == 0.00));
        }
    }
}
