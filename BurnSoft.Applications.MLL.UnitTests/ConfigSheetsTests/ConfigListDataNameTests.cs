using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class ConfigListDataNameTests
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
        /// The existing configuration name
        /// </summary>
        private string _existingConfigName;
        /// <summary>
        /// The existing identifier
        /// </summary>
        private int _existingId;
        /// <summary>
        /// The configuration name
        /// </summary>
        private string _ConfigName;
        /// <summary>
        /// The copy configuration name
        /// </summary>
        private string _copyConfigName;
        /// <summary>
        /// The is personal
        /// </summary>
        private bool _isPersonal;
        /// <summary>
        /// The is shotgun
        /// </summary>
        private bool _isShotgun;
        /// <summary>
        /// The notes
        /// </summary>
        private string _notes;
        /// <summary>
        /// The is active
        /// </summary>
        private bool _isActive;
        /// <summary>
        /// The is favorite
        /// </summary>
        private bool _isFavorite;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingConfigName = "HL8007U";
            _existingId = 13;
            _ConfigName = "Unit Test 9mm";
            _copyConfigName = $"Copy from {_ConfigName}";
            _isPersonal = true;  ///Replace with Function
            _isShotgun = false;
            _notes = "Competition Load Testing";
            _isActive = true;
            _isFavorite = true;
        }

        private void AddConfigNameIfNotExists(string name)
        {
            if (!ConfigListDataName.DataExists(_databasePath, name, out _))
            {
                ConfigListDataName.Add(_databasePath, name, true, false, "  ", true, true, out _);
            }
        }

        private void AddTestConfigNameExists()
        {
            if (!ConfigListDataName.DataExists(_databasePath, _ConfigName, out _))
            {
                ConfigListDataName.Add(_databasePath, _ConfigName, _isPersonal,
                    _isShotgun, _notes, _isActive, _isFavorite, out _);
            }
        }

        private void DeleteTestConfigNameExists()
        {
            if (ConfigListDataName.DataExists(_databasePath, _ConfigName, out _))
            {
                long id = ConfigListDataName.GetId(_databasePath, _ConfigName, out _);
                ConfigListDataName.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestConfigNames(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ConfigNameList> value = ConfigListDataName.GetDetails(_databasePath, _ConfigName, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigNameListData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigNameList> value = ConfigListDataName.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigNameListData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestConfigNameExists();
                bool value = ConfigListDataName.Add(_databasePath, _ConfigName, _isPersonal,
                    _isShotgun, _notes, _isActive, _isFavorite, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ConfigListDataName.GetId(_databasePath, _ConfigName, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigNameListData(
                    ConfigListDataName.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void CopyConfigTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigNameExists();
                bool value = ConfigListDataName.CopyConfig(_databasePath, _copyConfigName, _existingId, out _errOut);
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


        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigNameExists();
                PrintTestConfigNames();
                long id = ConfigListDataName.GetId(_databasePath, _ConfigName, out _);
                bool value = ConfigListDataName.Update(_databasePath, id, _ConfigName, _isPersonal,
                    _isShotgun, _notes, false, false, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestConfigNames("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void RenameTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigNameExists();
                PrintTestConfigNames();
                long id = ConfigListDataName.GetId(_databasePath, _ConfigName, out _);
                bool value = ConfigListDataName.Rename(_databasePath, id, $"(COPY) - {_ConfigName}", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestConfigNames("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigNameExists();
                long id = ConfigListDataName.GetId(_databasePath, _ConfigName, out _);
                bool value = ConfigListDataName.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = ConfigListDataName.GetId(_databasePath, _existingConfigName, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigNameList> value = ConfigListDataName.GetDetails(_databasePath, _existingConfigName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigNameListData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigNameList> value = ConfigListDataName.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigNameListData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Config Name Data")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataName.DataExists(_databasePath, out _errOut);
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
