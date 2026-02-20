using BurnSoft.Applications.MLL.AutoFill;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.UnitTests.AutoFill
{
    [TestClass]
    public class ConfigMetalicTests
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

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void SourceTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.Source(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void ConfigListNameTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.ConfigListName(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void GroupSizeTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.GroupSize(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void PowderWeightTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.PowderWeight(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void BulletTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.Bullet(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void PrimerTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.Primer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void CaseTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.Case(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void ConditionsTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.Conditions(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void TotalLenghtTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.TotalLenght(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void NotesTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.Notes(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Config and Loaders Log Metalic")]
        public void ConfigNameTest()
        {
            AutoCompleteStringCollection value = ConfigMetalic.ConfigName(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
