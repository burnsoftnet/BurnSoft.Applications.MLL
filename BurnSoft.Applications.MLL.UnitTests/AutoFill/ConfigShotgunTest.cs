using BurnSoft.Applications.MLL.AutoFill;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.UnitTests.AutoFill
{
    [TestClass]
    public class ConfigShotgunTest
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
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
        }
        
        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void SourceTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.Source(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void LoadInOuncesTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.LoadInOunces(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void WadManufacturerTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.WadManufacturer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void WadsTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.Wads(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void WadPriceTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.WadPrice(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void BushingPowderManufacturerTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.BushingPowderManufacturer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void BushingPowderNameTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.BushingPowderName(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void BushingShotManufacturerTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.BushingShotManufacturer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void BushingShotNameTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.BushingShotName(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void BushingShotChargeTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.BushingShotCharge(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void LogPatternTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.LogPattern(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void LogShotWeightTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.LogShotWeight(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void LogShotSizeTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.LogShotSize(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void LogCaseTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.LogCase(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void LogPowderBushingTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.LogPowderBushing(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void LogWadTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.LogWad(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Shotgun")]
        public void LogPrimerTest()
        {
            AutoCompleteStringCollection value = ConfigShotgun.LogPrimer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
