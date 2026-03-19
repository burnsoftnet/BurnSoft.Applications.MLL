using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static Azure.Core.HttpHeader;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class ShotgunPowderInventoryTests
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
        /// The charge
        /// </summary>
        private string _charge;
        /// <summary>
        /// The type
        /// </summary>
        private string _type;
        /// <summary>
        /// The powder name
        /// </summary>
        private string _powderName;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingManu = "Lee";
            _existingName = ".15";
            _existingId = 1;
            _manufacturer = "Lee";
            _name = "0.50";
            _charge = ".75 oz";
            _type = "Lee .15";
            _powderName = "Alliant Unique";
        }

        private void AddTestDataExists()
        {
            if (!ShotgunPowderInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                ShotgunPowderInventory.Add(_databasePath, _manufacturer, _name,
                    _charge, _type, _powderName, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (ShotgunPowderInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                long id = ShotgunPowderInventory.GetId(_databasePath, _manufacturer, _name, out _);
                ShotgunPowderInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCases(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ShotgunPowderListings> value = ShotgunPowderInventory.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunPowderListingsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunPowderListings> value = ShotgunPowderInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunPowderListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = ShotgunPowderInventory.Add(_databasePath, _manufacturer, _name,
                    _charge, _type, _powderName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ShotgunPowderInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunPowderListingsData(ShotgunPowderInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestCases();
                long id = ShotgunPowderInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = ShotgunPowderInventory.Update(_databasePath, id, _manufacturer, _name,
                    _charge, _type, _powderName + 1, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = ShotgunPowderInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = ShotgunPowderInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = ShotgunPowderInventory.Delete(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = ShotgunPowderInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<ShotgunPowderListings> value = ShotgunPowderInventory.GetDetails(_databasePath, 
                    _manufacturer, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunPowderListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long _existingId = ShotgunPowderInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
                List<ShotgunPowderListings> value = ShotgunPowderInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunPowderListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ShotgunPowderInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Powder")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = ShotgunPowderInventory.DataExists(_databasePath, _manufacturer, _name, out _errOut);
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
