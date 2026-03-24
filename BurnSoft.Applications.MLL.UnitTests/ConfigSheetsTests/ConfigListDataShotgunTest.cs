using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class ConfigListDataShotgunTest
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
        /// The copy configuration name
        /// </summary>
        private string _copyConfigName;
        /// <summary>
        /// The configuration identifier
        /// </summary>
        private int _configId;
        /// <summary>
        /// The copy configuration identifier
        /// </summary>
        private int _copyConfigId;
        /// <summary>
        /// The ammo type
        /// </summary>
        private int _ammoType;
        /// <summary>
        /// The caliber identifier
        /// </summary>
        private int _caliberId;
        /// <summary>
        /// The primer identifier
        /// </summary>
        private int _primerId;
        /// <summary>
        /// The case identifier
        /// </summary>
        private int _caseId;
        /// <summary>
        /// The source
        /// </summary>
        private string _source;
        /// <summary>
        /// The shot weight
        /// </summary>
        private double _shotWeight;
        /// <summary>
        /// The shot weight text
        /// </summary>
        private string _shotWeightText;
        /// <summary>
        /// The shot size
        /// </summary>
        private long _shotSize;
        /// <summary>
        /// The bushing
        /// </summary>
        private long _bushing;
        /// <summary>
        /// The wad
        /// </summary>
        private long _wad;
        /// <summary>
        /// The shot charge load
        /// </summary>
        private long _shotChargeLoad;
        /// <summary>
        /// The gun identifier
        /// </summary>
        private long _gunId;
        /// <summary>
        /// The is personal
        /// </summary>
        private bool _isPersonal;
        /// <summary>
        /// The list type identifier
        /// </summary>
        private long _listTypeId;
        /// <summary>
        /// The bushing identifier
        /// </summary>
        private long _bushingId;
        /// <summary>
        /// The charge bar identifier
        /// </summary>
        private long _chargeBarId;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingConfigId = 24;
            _existingId = 4;
            _ConfigName = "Unit Test 12GA";
            _copyConfigName = $"Copy from {_ConfigName}";
            AddConfigNameIfNotExists(_ConfigName);
            _configId = Convert.ToInt32(ConfigListDataName.GetId(_databasePath, _ConfigName, out _errOut));
            AddConfigNameIfNotExists(_copyConfigName);
            _copyConfigId = Convert.ToInt32(ConfigListDataName.GetId(_databasePath, _copyConfigName, out _errOut));
            _ammoType = 8;
            _caliberId = 1;
            _primerId = 12;
            _caseId = 5;
            _source = "UnItest Reloaders Guide";
            _shotWeight = 0.875;
            _shotWeightText = "7/8";
            _shotSize = 0;
            _bushing = 0;
            _wad = 12;
            _shotChargeLoad = 5;
            _gunId=1;
            _isPersonal = true;
            _listTypeId = 5;
            _bushingId = 0;
            _chargeBarId = 0;

        }

        private void AddConfigNameIfNotExists(string name)
        {
            if (!ConfigListDataName.DataExists(_databasePath, name, out _))
            {
                ConfigListDataName.Add(_databasePath, name, true, false, "  ", true, true, out _);
            }
        }

        private void AddTestConfigDataExists()
        {
            if (!ConfigListDataShotgun.DataExists(_databasePath, _configId, out _))
            {
                ConfigListDataShotgun.Add(_databasePath, _configId,
                    _ammoType, _caliberId, _primerId, _caseId, _shotWeight, _shotWeightText,
                    _shotSize, _bushing, _wad, _shotChargeLoad, _source, _gunId, _isPersonal,
                    _listTypeId, _bushingId, _chargeBarId, out _);
            }
        }

        private void DeleteTestConfigDataExists()
        {
            if (ConfigListDataShotgun.DataExists(_databasePath, _configId, out _))
            {
                long id = ConfigListDataShotgun.GetId(_databasePath, _configId, out _);
                ConfigListDataShotgun.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestConfigData(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ConfigListDataShotgunData> value = ConfigListDataShotgun.GetDetails(_databasePath, (long)_configId, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataShotgunDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListDataShotgunData> value = ConfigListDataShotgun.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestConfigDataExists();
                bool value = ConfigListDataShotgun.Add(_databasePath, _configId,
                    _ammoType, _caliberId, _primerId, _caseId, _shotWeight, _shotWeightText,
                    _shotSize, _bushing, _wad, _shotChargeLoad, _source, _gunId, _isPersonal,
                    _listTypeId, _bushingId, _chargeBarId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ConfigListDataShotgun.GetId(_databasePath, _configId, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataShotgunDataData(ConfigListDataShotgun.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void CopyConfigTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                bool value = ConfigListDataMetalic.CopyConfig(_databasePath, _copyConfigId, _existingConfigId, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                PrintTestConfigData();
                long id = ConfigListDataShotgun.GetId(_databasePath, _configId, out _);
                bool value = ConfigListDataShotgun.Update(_databasePath, id, _configId,
                    _ammoType, _caliberId, _primerId, _caseId, _shotWeight, _shotWeightText,
                    _shotSize, _bushing, _wad, _shotChargeLoad, " ", _gunId, false,
                    _listTypeId, _bushingId, _chargeBarId, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                long id = ConfigListDataShotgun.GetId(_databasePath, _configId, out _);
                bool value = ConfigListDataShotgun.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestConfigDataExists();
                long id = ConfigListDataShotgun.GetId(_databasePath, _configId, out _);
                bool value = ConfigListDataShotgun.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = ConfigListDataShotgun.GetId(_databasePath, _existingConfigId, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListDataShotgunData> value = ConfigListDataShotgun.GetDetails(_databasePath, (long)_existingConfigId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<ConfigListDataShotgunData> value = ConfigListDataShotgun.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ConfigListDataShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataShotgun.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Config Data")]
        public void DataExistsByConfigIdTest()
        {
            bool bAns = false;
            try
            {
                bool value = ConfigListDataShotgun.DataExists(_databasePath, _existingConfigId, out _errOut);
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
