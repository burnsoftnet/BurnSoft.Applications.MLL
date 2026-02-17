using BurnSoft.Applications.MLL.Global;
using BurnSoft.Applications.MLL.PeopleAndPlaces;
using BurnSoft.Applications.MLL.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Global
{
    [TestClass]
    public class MyRegistryTest
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

        [TestMethod, TestCategory("Registry Functions")]
        public void GetSettingsTest()
        {
            bool bAns = false;
            try
            {
                List<RegistrySettings> value = MyRegistry.GetSettings(out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.RegistrySettingsData(value));
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
