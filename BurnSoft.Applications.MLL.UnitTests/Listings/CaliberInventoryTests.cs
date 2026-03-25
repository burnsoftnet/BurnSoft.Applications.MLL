using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class CaliberInventoryTests
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
        /// The existing name
        /// </summary>
        private string _existingName;
        /// <summary>
        /// The existing identifier
        /// </summary>
        private int _existingId;
        /// <summary>
        /// The existing identifier
        /// </summary>
        /// <summary>
        /// The name
        /// </summary>
        private string _name;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingName = "9mm Luger";
            _existingId = 2;
            _name = "6.5 ARC";
        }

        private void AddTestCaliberExists()
        {
            if (!CaliberInventory.DataExists(_databasePath, _name, out _))
            {
                CaliberInventory.Add(_databasePath, _name, out _);
            }
        }

        private void DeleteTestCaliberExists()
        {
            if (CaliberInventory.DataExists(_databasePath, _name, out _))
            {
                long id = CaliberInventory.GetId(_databasePath, _name, out _);
                CaliberInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCalibers(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<CaliberLists> value = CaliberInventory.GetDetails(_databasePath, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.CaliberListsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<CaliberLists> value = CaliberInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.CaliberListsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestCaliberExists();
                bool value = CaliberInventory.Add(_databasePath, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = CaliberInventory.GetId(_databasePath, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.CaliberListsData(CaliberInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestCaliberExists();
                PrintTestCalibers();
                long id = CaliberInventory.GetId(_databasePath, _name, out _);
                bool value = CaliberInventory.Update(_databasePath, id, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestCalibers("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestCaliberExists();
                long id = CaliberInventory.GetId(_databasePath, _name, out _);
                bool value = CaliberInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestCaliberExists();
                bool value = CaliberInventory.Delete(_databasePath, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = CaliberInventory.GetId(_databasePath, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void GetNameTest()
        {
            bool bAns = false;
            try
            {
                string value = CaliberInventory.GetName(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE RETURNED {value}");
                bAns = (value.Length > 0);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void TotalConfigurationUsedByCaliberTest()
        {
            bool bAns = false;
            try
            {
                long value = CaliberInventory.TotalConfigurationUsedByCaliber(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE RETURNED {value}");
                bAns = (value > 0);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<CaliberLists> value = CaliberInventory.GetDetails(_databasePath, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.CaliberListsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<CaliberLists> value = CaliberInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.CaliberListsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = CaliberInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Calibers")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = CaliberInventory.DataExists(_databasePath, _existingName, out _errOut);
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
