using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class WadInventoryTests
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
        /// The load text
        /// </summary>
        private string _loadText;
        /// <summary>
        /// The qty
        /// </summary>
        private int _qty;
        /// <summary>
        /// The price
        /// </summary>
        private double _price;
        /// <summary>
        /// The gauge
        /// </summary>
        private string _gauge;
        /// <summary>
        /// The gauge identifier
        /// </summary>
        private long _gaugeId;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingManu = "Remington";
            _existingName = "Rem. SP20";
            _existingId = 13;
            _manufacturer = "Ballistic Products";
            _name = "Spiked Wads";
            _loadText = "1 1/8";
            _gauge = "20 Gauge";
            _gaugeId = 1;
            _qty = 1000;
            _price = 39.99;
        }

        private void AddTestDataExists()
        {
            if (!WadInventory.DataExists(_databasePath, _manufacturer, _name, _gauge, out _))
            {
                WadInventory.Add(_databasePath, _manufacturer, _name, _gauge, _gaugeId, 
                    _loadText,_qty, _price, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (WadInventory.DataExists(_databasePath, _manufacturer, _name, _gauge, out _))
            {
                long id = WadInventory.GetId(_databasePath, _manufacturer, _name, _gauge, out _);
                WadInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCases(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<WadData> value = WadInventory.GetDetails(_databasePath, _manufacturer, _name, _gauge, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.WadDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<WadData> value = WadInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.WadDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = WadInventory.Add(_databasePath, _manufacturer, _name, _gauge, _gaugeId,
                    _loadText, _qty, _price, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = WadInventory.GetId(_databasePath, _manufacturer, _name, _gauge, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.WadDataData(
                    WadInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestCases();
                long id = WadInventory.GetId(_databasePath, _manufacturer, _name, _gauge, out _);
                bool value = WadInventory.Update(_databasePath, id, _manufacturer, _name, _gauge, _gaugeId,
                    _loadText, _qty * 2, _price, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = WadInventory.GetId(_databasePath, _manufacturer, _name, _gauge, out _);
                bool value = WadInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = WadInventory.Delete(_databasePath, _manufacturer, _name, _gauge, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = WadInventory.GetId(_databasePath, _manufacturer, _name, _gauge, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"ID RETURNED {value}");
                bAns = (value > 0);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<WadData> value = WadInventory.GetDetails(_databasePath,
                    _manufacturer, _name, _gauge, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.WadDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long _existingId = WadInventory.GetId(_databasePath, _manufacturer, _name, _gauge, out _errOut);
                List<WadData> value = WadInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.WadDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = WadInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Wads")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = WadInventory.DataExists(_databasePath, _manufacturer, _name, _gauge, out _errOut);
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
