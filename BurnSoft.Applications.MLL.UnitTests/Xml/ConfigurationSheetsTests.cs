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
        private long _metallicConfigId;
        /// <summary>
        /// The save path
        /// </summary>
        private string _savePath;
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
            _metallicConfigId = 20;
            _savePath = Path.Combine(AppPath, "data\\Unit Test Pistol Config Sheet.xml");
        }

        [TestMethod, TestCategory("XML - Config Sheets")]
        public void GenerateMetallicTest()
        {
            bool value = ConfigurationSheets.Generate(_databasePath, _metallicConfigId, _savePath, out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            TestContext.WriteLine($"XML SAVED TO: {_savePath}");
            if (!value) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }
    }
}
