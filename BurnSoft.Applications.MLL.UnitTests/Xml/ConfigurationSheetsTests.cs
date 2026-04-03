using BurnSoft.Applications.MLL.Global;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using BurnSoft.Applications.MLL.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace BurnSoft.Applications.MLL.UnitTests.Xml
{
    [TestClass]
    public class ConfigurationSheetsTests
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
        /// The metallic configuration identifier
        /// </summary>
        private long _metallicRifleConfigId;
        /// <summary>
        /// The metallic pistol configuration identifier
        /// </summary>
        private long _metallicPistolConfigId;
        /// <summary>
        /// The save path
        /// </summary>
        private string _savePathRifle;
        /// <summary>
        /// The save path pistol
        /// </summary>
        private string _savePathPistol;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            string AppPath = AppDomain.CurrentDomain.BaseDirectory;
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _metallicRifleConfigId = 4;
            _metallicPistolConfigId = 20;
            _savePathRifle = Path.Combine(AppPath, "data\\Unit Test Rifle Config Sheet.xml");
            _savePathPistol = Path.Combine(AppPath, "data\\Unit Test Pistol Config Sheet.xml");
        }

        [TestMethod, TestCategory("XML - Config Sheets")]
        public void GenerateMetallicRifleTest()
        {
            bool value = ConfigurationSheets.Generate(_databasePath, _metallicRifleConfigId, _savePathRifle, out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            TestContext.WriteLine($"XML SAVED TO: {_savePathRifle}");
            if (!value) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }

        [TestMethod, TestCategory("XML - Config Sheets")]
        public void GenerateMetallicPistolTest()
        {
            bool value = ConfigurationSheets.Generate(_databasePath, _metallicPistolConfigId, _savePathPistol, out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            TestContext.WriteLine($"XML SAVED TO: {_savePathRifle}");
            if (!value) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }
    }
}
