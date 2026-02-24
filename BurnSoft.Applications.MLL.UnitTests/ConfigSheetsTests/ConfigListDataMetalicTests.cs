using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class ConfigListDataMetalicTests
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

        private int _existingConfigId;

        private int _existingId;

        private string _ConfigName;

        private int _configId;

        private int _ammoType;

        private int _caliberId;

        private int _bulletId;

        private int _primerId;

        private int _caseId;

        private string _source;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingConfigId = 4;
            _existingId = 4;
            _ConfigName = "Unit Test 9mm";
            _configId = 10;  ///Replace with Function
            _ammoType = 1;
            _caliberId = 2;
            _bulletId = 15;
            _primerId = 7;
            _caseId = 7;
            _source = "UnItest Reloaders Guide";
        }

        private void AddTestCasesExists()
        {
            if (!ConfigListDataMetalic.DataExists(_databasePath, _configId, out _))
            {
                ConfigListDataMetalic.Add(_databasePath, _configId,
                    _ammoType, _caliberId, _bulletId, _primerId, _caseId, _source, out _);
            }
        }

        private void DeleteTestCasesExists()
        {
            if (ConfigListDataMetalic.DataExists(_databasePath, _ConfigName, _configId, out _))
            {
                long id = ConfigListDataMetalic.GetId(_databasePath, _ConfigName, _configId, out _);
                ConfigListDataMetalic.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCases(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ConfigListDataMetalicData> value = ConfigListDataMetalic.GetDetails(_databasePath, _ConfigName, _configId, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataMetalicDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListDataMetalicData> value = ConfigListDataMetalic.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataMetalicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestCasesExists();
                bool value = ConfigListDataMetalic.Add(_databasePath, _ConfigName, _configId,
                    _ammoType, _caliberId, _bulletId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ConfigListDataMetalic.GetId(_databasePath, _ConfigName, _configId, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataMetalicDataData(ConfigListDataMetalic.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                PrintTestCases();
                long id = ConfigListDataMetalic.GetId(_databasePath, _ConfigName, _configId, out _);
                bool value = ConfigListDataMetalic.Update(_databasePath, id, _ConfigName, _configId,
                    _ammoType, _caliberId, _bulletId + 1, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                long id = ConfigListDataMetalic.GetId(_databasePath, _ConfigName, _configId, out _);
                bool value = ConfigListDataMetalic.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                bool value = ConfigListDataMetalic.Delete(_databasePath, _ConfigName, _configId, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = ConfigListDataMetalic.GetId(_databasePath, _existingConfigId, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListDataMetalicData> value = ConfigListDataMetalic.GetDetails(_databasePath, _existingConfigId, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataMetalicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListDataMetalicData> value = ConfigListDataMetalic.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataMetalicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataMetalic.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Config Data")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataMetalic.DataExists(_databasePath, _existingConfigId, _existingName, out _errOut);
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
