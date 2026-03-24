using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class ShotgunHullInventoryTests
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
        /// The existing guage
        /// </summary>
        private string _existingGuage;
        /// <summary>
        /// The manufacturer
        /// </summary>
        private string _manufacturer;
        /// <summary>
        /// The name
        /// </summary>
        private string _name;
        /// <summary>
        /// The guage
        /// </summary>
        private string _guage;
        /// <summary>
        /// The gun identifier
        /// </summary>
        private long _gunId;
        /// <summary>
        /// The length
        /// </summary>
        private string _length;
        /// <summary>
        /// The qty
        /// </summary>
        private int _qty;
        /// <summary>
        /// The price
        /// </summary>
        private double _price;
        /// <summary>
        /// The dram
        /// </summary>
        private string _dram;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingManu = "Winchester";
            _existingName = "Plastic Shells with Plastic Basewad";
            _existingGuage = "20 Gauge";
            _existingId = 1;
            _manufacturer = "Starline";
            _name = "12GA Starline Primed Hulls 2 3/4\"";
            _guage = "12 Gauge";
            _gunId = 2;
            _length = "2 3/4\"";
            _qty = 69;
            _price = 20.55;
            _dram = "  ";
        }

        private void AddTestCasesExists()
        {
            if (!ShotgunHullInventory.DataExists(_databasePath, _manufacturer, _name, _guage, out _))
            {
                ShotgunHullInventory.Add(_databasePath, _manufacturer, _name,
                    _guage, _gunId, _length, _qty, _price, _dram, out _);
            }
        }

        private void DeleteTestCasesExists()
        {
            if (ShotgunHullInventory.DataExists(_databasePath, _manufacturer, _name, _guage, out _))
            {
                long id = ShotgunHullInventory.GetId(_databasePath, _manufacturer, _name, _guage, out _);
                ShotgunHullInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCases(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ShotgunHullData> value = ShotgunHullInventory.GetDetails(_databasePath, _manufacturer, _name, _guage, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunHullDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunHullData> value = ShotgunHullInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunHullDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestCasesExists();
                bool value = ShotgunHullInventory.Add(_databasePath, _manufacturer, _name,
                    _guage, _gunId, _length, _qty, _price, _dram, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ShotgunHullInventory.GetId(_databasePath, _manufacturer, _name, _guage, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunHullDataData(ShotgunHullInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                PrintTestCases();
                long id = ShotgunHullInventory.GetId(_databasePath, _manufacturer, _name, _guage, out _);
                bool value = ShotgunHullInventory.Update(_databasePath, id, _manufacturer, _name,
                    _guage, _gunId, _length, (_qty * 2), _price, _dram, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestCases("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void UpdateQtyTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                PrintTestCases();
                long id = ShotgunHullInventory.GetId(_databasePath, _manufacturer, _name, _guage, out _);

                double currentPrice = 0;
                int currentQty = 0;
                double currentPricePerItenm = 0;
                List<ShotgunHullData> lst = ShotgunHullInventory.GetDetails(_databasePath, id, out _);

                foreach (ShotgunHullData l in lst)
                {
                    currentPrice = l.Price;
                    currentQty = l.Qty;
                    currentPricePerItenm = l.EstimatedPricePerItem;
                }

                bool value = ShotgunHullInventory.UpdateQty(_databasePath, id, currentQty, currentPrice,
                    currentPricePerItenm, 1000, 20.00, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestCases("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                long id = ShotgunHullInventory.GetId(_databasePath, _manufacturer, _name, _guage, out _);
                bool value = ShotgunHullInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                bool value = ShotgunHullInventory.Delete(_databasePath, _manufacturer, _name, _guage, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = ShotgunHullInventory.GetId(_databasePath, _existingManu, _existingName, _existingGuage, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunHullData> value = ShotgunHullInventory.GetDetails(_databasePath, _existingManu, 
                    _existingName, _existingGuage, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunHullDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunHullData> value = ShotgunHullInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunHullDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ShotgunHullInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Hulls/Cases")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = ShotgunHullInventory.DataExists(_databasePath, _existingManu, _existingName, _existingGuage, out _errOut);
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
    }
}
