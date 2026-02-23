using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class ShotgunBushingInventoryTests
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
        /// The shot identifier
        /// </summary>
        private int _shotId;
        /// <summary>
        /// The powder identifier
        /// </summary>
        private int _powderId;

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
            _shotId = 1;
            _powderId = 1;
        }

        private void AddTestCasesExists()
        {
            if (!ShotgunBushingInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                ShotgunBushingInventory.Add(_databasePath, _manufacturer, _name,
                    _charge, _shotId, _powderId, out _);
            }
        }

        private void DeleteTestCasesExists()
        {
            if (ShotgunBushingInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                long id = ShotgunBushingInventory.GetId(_databasePath, _manufacturer, _name, out _);
                ShotgunBushingInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCases(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ShotgunBushingListings> value = ShotgunBushingInventory.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunBushingListingsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunBushingListings> value = ShotgunBushingInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunBushingListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestCasesExists();
                bool value = ShotgunBushingInventory.Add(_databasePath, _manufacturer, _name,
                    _charge, _shotId, _powderId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ShotgunBushingInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunBushingListingsData(ShotgunBushingInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                PrintTestCases();
                long id = ShotgunBushingInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = ShotgunBushingInventory.Update(_databasePath, id, _manufacturer, _name,
                    _charge, _shotId, _powderId + 1, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                long id = ShotgunBushingInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = ShotgunBushingInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                bool value = ShotgunBushingInventory.Delete(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = ShotgunBushingInventory.GetId(_databasePath, _existingManu, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunBushingListings> value = ShotgunBushingInventory.GetDetails(_databasePath, _existingManu, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunBushingListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunBushingListings> value = ShotgunBushingInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunBushingListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ShotgunBushingInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Bushings")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = ShotgunBushingInventory.DataExists(_databasePath, _existingManu, _existingName, out _errOut);
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
