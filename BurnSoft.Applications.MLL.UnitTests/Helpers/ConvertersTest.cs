using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BurnSoft.Applications.MLL.UnitTests.Settings;

namespace BurnSoft.Applications.MLL.UnitTests.Helpers
{
    [TestClass]
    public class ConvertersTest
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
        /// The conver this to number
        /// </summary>
        private string ConverThisToNumber;
        /// <summary>
        /// The conver this to number expected
        /// </summary>
        private double ConverThisToNumberExpected;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("", TestContext);
            _errOut = @"";
            ConverThisToNumber = Vs2019.GetSetting("ConverThisToNumber", TestContext);
            ConverThisToNumberExpected = Convert.ToDouble(Vs2019.GetSetting("ConverThisToNumberExpected", TestContext));
        }
        [TestMethod, TestCategory("Helpers - Converters")]
        public void ConvertToNumberTest()
        {
            double value = BurnSoft.Applications.MLL.Helpers.Converters.ConvertToNumber(ConverThisToNumber, out _errOut);

            General.HasTrueValue(value == ConverThisToNumberExpected, _errOut);
        }
    }
}
