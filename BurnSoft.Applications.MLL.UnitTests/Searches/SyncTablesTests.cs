using BurnSoft.Applications.MLL.Search;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Searches
{
    [TestClass]
    public class SyncTablesTests
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
        /// The table name
        /// </summary>
        private string _tableName;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _tableName = "Config_List_Data_NSG";
        }

        [TestMethod, TestCategory("Sync Tables")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = SyncTables.GetId(_databasePath, _tableName, out _errOut);
                List<SyncTablesData> value = SyncTables.GetDetails(_databasePath, (int)id, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.SyncTablesDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Sync Tables")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<SyncTablesData> value = SyncTables.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.SyncTablesDataData(value));
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
            if (!SyncTables.DataExists(_databasePath, _tableName, out _))
            {
                SyncTables.Add(_databasePath, _tableName, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (SyncTables.DataExists(_databasePath, _tableName, out _))
            {
                long id = SyncTables.GetId(_databasePath, _tableName, out _);
                SyncTables.Delete(_databasePath, id, out _);
            }
        }

        [TestMethod, TestCategory("Sync Tables")]
        public void GetDetailsDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<SyncTablesData> value = SyncTables.GetDetails(_databasePath, _tableName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.SyncTablesDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Sync Tables")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = SyncTables.GetId(_databasePath, _tableName, out _errOut);
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

        [TestMethod, TestCategory("Sync Tables")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = SyncTables.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Sync Tables")]
        public void DataExistsDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = SyncTables.DataExists(_databasePath, _tableName, out _errOut);
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
            List<SyncTablesData> value = SyncTables.GetDetails(_databasePath, _tableName, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.SyncTablesDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Sync Tables")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = SyncTables.Add(_databasePath, _tableName, out _errOut);
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

        [TestMethod, TestCategory("Sync Tables")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestData();
                long id = SyncTables.GetId(_databasePath, _tableName, out _);
                bool value = SyncTables.Update(_databasePath, id, _tableName + "_test", out _errOut);
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

        [TestMethod, TestCategory("Sync Tables")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = SyncTables.GetId(_databasePath, _tableName, out _);
                bool value = SyncTables.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Sync Tables")]
        public void DeleteByDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = SyncTables.Delete(_databasePath, _tableName, out _errOut);
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
