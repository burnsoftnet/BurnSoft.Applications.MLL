using BurnSoft.Applications.MLL.Search;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Searches
{
    [TestClass]
    public class ShotgunDataTests
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
        /// The description
        /// </summary>
        private string _description;
        /// <summary>
        /// The column name
        /// </summary>
        private string _columnName;
        /// <summary>
        /// The column type
        /// </summary>
        private string _columnType;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _description = "Primer Type";
            _columnName = "priType";
            _columnType = "String";

        }

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = ShotgunData.GetId(_databasePath, _description, out _errOut);
                List<SearchFieldsData> value = ShotgunData.GetDetails(_databasePath, (int)id, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.SearchFieldsDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<SearchFieldsData> value = ShotgunData.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.SearchFieldsDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        private void AddTestDataExists()
        {
            if (!ShotgunData.DataExists(_databasePath, _description, out _))
            {
                ShotgunData.Add(_databasePath, _description,
                    _columnName, _columnType, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (ShotgunData.DataExists(_databasePath, _description, out _))
            {
                long id = ShotgunData.GetId(_databasePath, _description, out _);
                ShotgunData.Delete(_databasePath, id, out _);
            }
        }

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void GetDetailsDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<SearchFieldsData> value = ShotgunData.GetDetails(_databasePath, _description, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.SearchFieldsDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = ShotgunData.GetId(_databasePath, _description, out _errOut);
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

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ShotgunData.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void DataExistsDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = ShotgunData.DataExists(_databasePath, _description, out _errOut);
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

        private void PrintTestData(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<SearchFieldsData> value = ShotgunData.GetDetails(_databasePath, _description, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.SearchFieldsDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = ShotgunData.Add(_databasePath, _description,
                    _columnName, _columnType, out _errOut);
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

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestData();
                long id = ShotgunData.GetId(_databasePath, _description, out _);
                bool value = ShotgunData.Update(_databasePath, id, _description,
                    _columnName, "Double", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = true;
                PrintTestData("AFTER");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = ShotgunData.GetId(_databasePath, _description, out _);
                bool value = ShotgunData.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Search Fields - Shotgun")]
        public void DeleteByDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = ShotgunData.Delete(_databasePath, _description, out _errOut);
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
