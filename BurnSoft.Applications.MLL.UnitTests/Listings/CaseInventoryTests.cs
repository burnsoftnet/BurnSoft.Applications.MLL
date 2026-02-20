using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class CaseInventoryTests
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
        /// The trim to length
        /// </summary>
        private string _trimToLength;
        /// <summary>
        /// The is new
        /// </summary>
        private bool _isNew;
        /// <summary>
        /// The times used
        /// </summary>
        private int _timesUsed;
        /// <summary>
        /// The qty
        /// </summary>
        private int _qty;
        /// <summary>
        /// The price
        /// </summary>
        private double _price;
        /// <summary>
        /// The caliber identifier
        /// </summary>
        private long _caliberId;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingManu = "Federal";
            _existingName = "Fed 9mm";
            _existingId = 4;
            _manufacturer = "Starline";
            _name = "Starline 9mm Steel Case";
            _trimToLength = "0.355";
            _isNew = true;
            _timesUsed = 1;
            _qty = 1200;
            _price = 69.00;
            _caliberId = 1;
        }

        private void AddTestCasesExists()
        {
            if (!CaseInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                CaseInventory.Add(_databasePath, _manufacturer, _name,
                    _trimToLength, _isNew, _timesUsed, _qty, _price, _caliberId, out _);
            }
        }

        private void DeleteTestCasesExists()
        {
            if (CaseInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                long id = CaseInventory.GetId(_databasePath, _manufacturer, _name, out _);
                CaseInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCases(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<CaseListings> value = CaseInventory.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.CaseListingsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<CaseListings> value = CaseInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.CaseListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestCasesExists();
                bool value = CaseInventory.Add(_databasePath, _manufacturer, _name,
                    _trimToLength, _isNew, _timesUsed, _qty, _price, _caliberId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = CaseInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.CaseListingsData(CaseInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                PrintTestCases();
                long id = CaseInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = CaseInventory.Update(_databasePath, id, _manufacturer, _name,
                    _trimToLength, _isNew, _timesUsed, (_qty * 2), _price, _caliberId, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                long id = CaseInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = CaseInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                bool value = CaseInventory.Delete(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = CaseInventory.GetId(_databasePath, _existingManu, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<CaseListings> value = CaseInventory.GetDetails(_databasePath, _existingManu, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.CaseListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<CaseListings> value = CaseInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.CaseListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = CaseInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Cases")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = CaseInventory.DataExists(_databasePath, _existingManu, _existingName, out _errOut);
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
