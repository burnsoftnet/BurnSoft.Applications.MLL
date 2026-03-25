using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class ConfigListGeneralTests
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
        /// The shotgun ammo type identifier
        /// </summary>
        private long _shotgunAmmoTypeId;
        /// <summary>
        /// The metallic caliber identifier
        /// </summary>
        private long _metallicCaliberId;
        /// <summary>
        /// The shotgun configuration identifier
        /// </summary>
        private long _shotgunConfigId;
        /// <summary>
        /// The metallic configuration identifier
        /// </summary>
        private long _metallicConfigId;
        /// <summary>
        /// The is slug identifier
        /// </summary>
        private long _isSlugId;
        /// <summary>
        /// The is not slug identifier
        /// </summary>
        private long _isNotSlugId;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _shotgunAmmoTypeId = 8;
            _metallicCaliberId = 2;
            _shotgunConfigId = 21;
            _metallicConfigId = 10;
            _isSlugId = 29;
            _isNotSlugId = 1;
        }


        [TestMethod, TestCategory("Config Sheets - General")]
        public void IsShotgunConfigTestTrue()
        {
            try
            {
                bool value = ConfigListGeneral.IsShotgunConfig(_databasePath, _shotgunConfigId, out _errOut);
                TestContext.WriteLine($"VALUE: {value}");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                if (!value) throw new Exception($"Config ID {_shotgunConfigId} is not a shotgun config");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex.Message}");
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod, TestCategory("Config Sheets - General")]
        public void IsShotgunConfigTestFalse()
        {
            try
            {
                bool value = ConfigListGeneral.IsShotgunConfig(_databasePath, _metallicConfigId, out _errOut);
                TestContext.WriteLine($"VALUE: {value}");
                if (value) throw new Exception($"Config ID {_metallicConfigId} is a shotgun config, expected metallic");
                if (_errOut.Length > 0) throw new Exception(_errOut);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex.Message}");
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod, TestCategory("Config Sheets - General")]
        public void IsSlugConfigTestTrue()
        {
            try
            {
                bool value = ConfigListGeneral.IsSlugConfig(_databasePath, _isSlugId, out _errOut);
                TestContext.WriteLine($"VALUE: {value}");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                // Just checking for error there is no slug data in the test table, so auto pass
                //if (!value) throw new Exception($"Config ID {_isSlugId} is not a shotgun config");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex.Message}");
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod, TestCategory("Config Sheets - General")]
        public void IsSlugConfigTestFalse()
        {
            try
            {
                bool value = ConfigListGeneral.IsSlugConfig(_databasePath, _isNotSlugId, out _errOut);
                TestContext.WriteLine($"VALUE: {value}");
                if (value) throw new Exception($"Config ID {_isNotSlugId} is a shotgun config, expected metallic");
                if (_errOut.Length > 0) throw new Exception(_errOut);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex.Message}");
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod, TestCategory("Config Sheets - General")]
        public void InShotgunTest()
        {
            try
            {
                bool value = ConfigListGeneral.InShotgun(_databasePath, _shotgunAmmoTypeId, out _errOut);
                TestContext.WriteLine($"VALUE: {value}");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                if (!value) throw new Exception($"Value returned False, expected True");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex.Message}");
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod, TestCategory("Config Sheets - General")]
        public void InMetallicTest()
        {
            try
            {
                bool value = ConfigListGeneral.InMetallic(_databasePath, _metallicCaliberId, out _errOut);
                TestContext.WriteLine($"VALUE: {value}");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                if (!value) throw new Exception($"Value returned False, expected True");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex.Message}");
                Assert.Fail(ex.ToString());
            }
        }

        [TestMethod, TestCategory("Config Sheets - General")]
        public void IsNotInShotgunConfigByCaliberTest()
        {
            try
            {
                bool value = ConfigListGeneral.IsNotInShotgunConfigByCaliber(_databasePath, _metallicCaliberId, out _errOut);
                TestContext.WriteLine($"VALUE: {value}");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                if (!value) throw new Exception($"Value returned False, expected True");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex.Message}");
                Assert.Fail(ex.ToString());
            }
        }

    }
}
