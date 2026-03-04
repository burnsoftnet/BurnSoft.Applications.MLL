using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class PrimerTypesTests
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
            _existingName = "Large Rifle";
            _existingId = 1;
            _name = "Extra Large Rifle";
        }

        private void AddTestPrimerExists()
        {
            if (!PrimerTypes.DataExists(_databasePath, _name, out _))
            {
                PrimerTypes.Add(_databasePath, _name, out _);
            }
        }

        private void DeleteTestPrimerExists()
        {
            if (PrimerTypes.DataExists(_databasePath, _name, out _))
            {
                long id = PrimerTypes.GetId(_databasePath, _name, out _);
                PrimerTypes.Delete(_databasePath, id, out _);
            }
        }

        private void PrintAllData(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<PrimerTypeListings> value = PrimerTypes.GetAll(_databasePath, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerTypeListingsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<PrimerTypeListings> value = PrimerTypes.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerTypeListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestPrimerExists();
                bool value = PrimerTypes.Add(_databasePath, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = PrimerTypes.GetId(_databasePath, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerTypeListingsData(PrimerTypes.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestPrimerExists();
                PrintAllData();
                long id = PrimerTypes.GetId(_databasePath, _name, out _);
                bool value = PrimerTypes.Update(_databasePath, id, $"{_name} hybrid", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintAllData("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestPrimerExists();
                long id = PrimerTypes.GetId(_databasePath, _name, out _);
                bool value = PrimerTypes.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestPrimerExists();
                bool value = PrimerTypes.Delete(_databasePath, _name, out _errOut);
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

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = PrimerTypes.GetId(_databasePath, _existingName, out _errOut);
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

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<PrimerTypeListings> value = PrimerTypes.GetDetails(_databasePath, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerTypeListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<PrimerTypeListings> value = PrimerTypes.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PrimerTypeListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = PrimerTypes.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("General Listings - Primer Types")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = PrimerTypes.DataExists(_databasePath, _existingName, out _errOut);
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
