using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BurnSoft.Applications.MLL.UnitTests.Global
{
    [TestClass]
    public class GeneralSettingsTest
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
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
        }

        [TestMethod, TestCategory("General Settings")]
        public void MY_HELP_FILETest()
        {
            string value = MLL.Global.GeneralSettings.MY_HELP_FILE;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MY_HOTFIX_FILETest()
        {
            string value = MLL.Global.GeneralSettings.MY_HOTFIX_FILE;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MY_BACKUPTest()
        {
            string value = MLL.Global.GeneralSettings.MY_BACKUP;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MY_RESTORETest()
        {
            string value = MLL.Global.GeneralSettings.MY_RESTORE;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MENU_WIKITest()
        {
            string value = MLL.Global.GeneralSettings.MENU_WIKI;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MENU_SHOPTest()
        {
            string value = MLL.Global.GeneralSettings.MENU_SHOP;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MENU_BUGTest()
        {
            string value = MLL.Global.GeneralSettings.MENU_BUG;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MENU_SUPPORTTest()
        {
            string value = MLL.Global.GeneralSettings.MENU_SUPPORT;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MENU_SITESEARCHTest()
        {
            string value = MLL.Global.GeneralSettings.MENU_SITESEARCH;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }

        [TestMethod, TestCategory("General Settings")]
        public void MENU_LINKSTest()
        {
            string value = MLL.Global.GeneralSettings.MENU_LINKS;
            TestContext.WriteLine(value);
            General.HasTrueValue(value.Length > 0, _errOut);
        }
    }
}
