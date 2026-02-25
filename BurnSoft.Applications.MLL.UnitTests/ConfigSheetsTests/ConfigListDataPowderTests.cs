using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class ConfigListDataPowderTests
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
        /// The existing configuration identifier
        /// </summary>
        private int _existingConfigId;
        /// <summary>
        /// The existing identifier
        /// </summary>
        private int _existingId;
        /// <summary>
        /// The configuration name
        /// </summary>
        private string _ConfigName;
        /// <summary>
        /// The configuration identifier
        /// </summary>
        private long _configId;

        private long _powderId;

        private double _loadMin;

        private double _loadMid;
        
        private double _loadMax;
        
        private double _fpsMin;
        
        private double _fpsMid;
        private double _fpsMax;
        private double _cupsMin;
        private double _cupsMid;
        private double _cupsMax;
        private bool _isDefault;

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
            _existingId = 3;
            _ConfigName = "Unit Test 9mm";
            _configId = Convert.ToInt32(ConfigListDataName.GetId(_databasePath, _ConfigName, out _));
            _powderId = 9;
            _loadMin = 6.5;
            _loadMid = 6.9;
            _loadMax = 8;
            _fpsMin = 800;
            _fpsMid = 900;
            _fpsMax = 1000;
            _cupsMin = 0;
            _cupsMid = 0;
            _cupsMax = 0;
            _isDefault = true;
        }

        private void AddTestConfigDataExists()
        {
            if (!ConfigListDataPowder.DataExists(_databasePath, _configId, out _))
            {
                ConfigListDataPowder.Add(_databasePath, _configId,
                    _powderId, _loadMin, _loadMid, _loadMax, _fpsMin, _fpsMid, 
                    _fpsMax, _cupsMin, _cupsMid, _cupsMax, _isDefault, out _);
            }
        }

        private void DeleteTestConfigDataExists()
        {
            if (ConfigListDataPowder.DataExists(_databasePath, _configId, out _))
            {
                long id = ConfigListDataPowder.GetId(_databasePath, (int)_configId, out _);
                ConfigListDataPowder.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestConfigData(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ConfigListPowderData> value = ConfigListDataPowder.GetDetails(_databasePath, (long)_configId, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListPowderDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListPowderData> value = ConfigListDataPowder.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListPowderDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestConfigDataExists();
                bool value = ConfigListDataPowder.Add(_databasePath, _configId,
                    _powderId, _loadMin, _loadMid, _loadMax, _fpsMin, _fpsMid,
                    _fpsMax, _cupsMin, _cupsMid, _cupsMax, _isDefault, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ConfigListDataPowder.GetId(_databasePath, (int)_configId, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListPowderDataData(ConfigListDataPowder.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                PrintTestConfigData();
                long id = ConfigListDataPowder.GetId(_databasePath, (int)_configId, out _);
                bool value = ConfigListDataPowder.Update(_databasePath, id, _configId,
                    _powderId, _loadMin, _loadMid, _loadMax, _fpsMin, _fpsMid,
                    _fpsMax, _cupsMin, _cupsMid, _cupsMax, _isDefault, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestConfigData("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                long id = ConfigListDataPowder.GetId(_databasePath, (int)_configId, out _);
                bool value = ConfigListDataPowder.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                long id = ConfigListDataPowder.GetId(_databasePath, (int)_configId, out _);
                bool value = ConfigListDataPowder.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = ConfigListDataPowder.GetId(_databasePath, _existingConfigId, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListPowderData> value = ConfigListDataPowder.GetDetails(_databasePath, (long)_existingConfigId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListPowderDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListPowderData> value = ConfigListDataPowder.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListPowderDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataPowder.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Metalic Powder Data")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataPowder.DataExists(_databasePath, _existingConfigId, out _errOut);
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
