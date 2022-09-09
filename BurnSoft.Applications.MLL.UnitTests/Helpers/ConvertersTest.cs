using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BurnSoft.Applications.MLL.UnitTests.Settings;
// ReSharper disable CompareOfFloatsByEqualityOperator

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

        private string ConvertOuncesToDouble;

        private double ConvertOuncesToDoubleExpected;
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
            ConvertOuncesToDouble = Vs2019.GetSetting("ConvertOuncesToDouble", TestContext);
            ConvertOuncesToDoubleExpected = Convert.ToDouble(Vs2019.GetSetting("ConvertOuncesToDoubleExpected", TestContext));
        }

        [TestMethod, TestCategory("Helpers - Converters")]
        public void ConvertToNumberTest()
        {
            double value = BurnSoft.Applications.MLL.Helpers.Converters.ConvertToNumber(ConverThisToNumber, out _errOut);
            TestContext.WriteLine($"RETURNED VALUE: {value}, expected: {ConverThisToNumberExpected}");
            General.HasTrueValue(value == ConverThisToNumberExpected, _errOut);
        }

        [TestMethod, TestCategory("Helpers - Converters")]
        public void ConvertOuncesToDoubleTest()
        {
            double value = BurnSoft.Applications.MLL.Helpers.Converters.ConvertOuncesToDouble(ConvertOuncesToDouble, out _errOut);
            TestContext.WriteLine($"RETURNED VALUE: {value}, explected {ConvertOuncesToDoubleExpected}");
            General.HasTrueValue(value == ConvertOuncesToDoubleExpected, _errOut);
        }
    }
}
