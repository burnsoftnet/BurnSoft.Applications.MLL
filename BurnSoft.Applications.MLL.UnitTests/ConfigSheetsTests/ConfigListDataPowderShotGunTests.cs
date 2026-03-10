using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class ConfigListDataPowderShotGunShotGunTests
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
        private double _psiMin;
        private double _psiMid;
        private double _psiMax;
        private double _lupMin;
        private double _lupMid;
        private double _lupMax;
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
            _existingConfigId = 25;
            _existingId = 11;
            _ConfigName = "Unit Test 12ga";
            _configId = Convert.ToInt32(ConfigListDataName.GetId(_databasePath, _ConfigName, out _));
            _powderId = 9;
            _loadMin = 6.5;
            _loadMid = 6.9;
            _loadMax = 8;
            _fpsMin = 800;
            _fpsMid = 900;
            _fpsMax = 1000;
            _psiMin = 0;
            _psiMid = 0;
            _psiMax = 0;
            _lupMin = 0;
            _lupMid = 0;
            _lupMax = 0;
            _isDefault = true;
        }

        private void AddTestConfigDataExists()
        {
            if (!ConfigListDataPowderShotGun.DataExists(_databasePath, _configId, out _))
            {
                ConfigListDataPowderShotGun.Add(_databasePath, _configId,
                    _powderId, _loadMin, _loadMid, _loadMax, _fpsMin, _fpsMid, 
                    _fpsMax, _psiMin, _psiMid, _psiMax, _lupMin, _lupMid, _lupMax, _isDefault, out _);
            }
        }

        private void DeleteTestConfigDataExists()
        {
            if (ConfigListDataPowderShotGun.DataExists(_databasePath, _configId, out _))
            {
                long id = ConfigListDataPowderShotGun.GetId(_databasePath, (int)_configId, out _);
                ConfigListDataPowderShotGun.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestConfigData(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ConfigListPowderData> value = ConfigListDataPowderShotGun.GetDetails(_databasePath, (long)_configId, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListPowderDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListPowderData> value = ConfigListDataPowderShotGun.GetAll(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestConfigDataExists();
                bool value = ConfigListDataPowderShotGun.Add(_databasePath, _configId,
                    _powderId, _loadMin, _loadMid, _loadMax, _fpsMin, _fpsMid,
                    _fpsMax, _psiMin, _psiMid, _psiMax, _lupMin, _lupMid, _lupMax, _isDefault, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ConfigListDataPowderShotGun.GetId(_databasePath, (int)_configId, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListPowderDataData(
                    ConfigListDataPowderShotGun.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                PrintTestConfigData();
                long id = ConfigListDataPowderShotGun.GetId(_databasePath, (int)_configId, out _);
                bool value = ConfigListDataPowderShotGun.Update(_databasePath, id, _configId,
                    _powderId, _loadMin, _loadMid, _loadMax, _fpsMin, _fpsMid,
                    _fpsMax, _psiMin, _psiMid, _psiMax, _lupMin, _lupMid, _lupMax, _isDefault, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                long id = ConfigListDataPowderShotGun.GetId(_databasePath, (int)_configId, out _);
                bool value = ConfigListDataPowderShotGun.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                long id = ConfigListDataPowderShotGun.GetId(_databasePath, (int)_configId, out _);
                bool value = ConfigListDataPowderShotGun.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = ConfigListDataPowderShotGun.GetId(_databasePath, _existingConfigId, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void GetDefaultPowderIdTest()
        {
            bool bAns = false;
            try
            {
                double powderLoad = 0;
                double? fps = 0;
                long value = ConfigListDataPowderShotGun.GetDefaultPowderId(_databasePath, _existingConfigId,
                    out powderLoad, out fps, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"POWDER ID RETURNED {value}");
                TestContext.WriteLine($"Preffered Powder Load {powderLoad}");
                TestContext.WriteLine($"Preffered Powder FPS {fps}");
                bAns = (value > 0);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void GetDefaultPowderIdOverrideTest()
        {
            bool bAns = false;
            try
            {
                double powderLoad = 0;
                long value = ConfigListDataPowderShotGun.GetDefaultPowderId(_databasePath, _existingConfigId,
                    out powderLoad, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"POWDER ID RETURNED {value}");
                TestContext.WriteLine($"Preffered Powder Load {powderLoad}");
                bAns = (value > 0);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListPowderData> value = ConfigListDataPowderShotGun.GetDetails(_databasePath, (long)_existingConfigId, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListPowderData> value = ConfigListDataPowderShotGun.GetDetails(_databasePath, _existingId, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataPowderShotGun.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Powder Data")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataPowderShotGun.DataExists(_databasePath, _existingConfigId, out _errOut);
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
