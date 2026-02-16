using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BurnSoft.Applications.MLL.UnitTests.Global
{
    [TestClass]
    public class WeightValuesTest
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

        [TestMethod, TestCategory("Weight Values")]
        public void WEIGHT_GRAINS_1LBS_Test()
        {
            var value = MLL.Global.WeightValues.WEIGHT_GRAINS_1LBS;
            TestContext.WriteLine($"{value}");
            General.HasTrueValue(value > 0, _errOut);
        }

        [TestMethod, TestCategory("Weight Values")]
        public void WEIGHT_GRAINS_1GM_Test()
        {
            var value = MLL.Global.WeightValues.WEIGHT_GRAINS_1GM;
            TestContext.WriteLine($"{value}");
            General.HasTrueValue(value > 0, _errOut);
        }

        [TestMethod, TestCategory("Weight Values")]
        public void WEIGHT_GRAMS_1LBS_Test()
        {
            var value = MLL.Global.WeightValues.WEIGHT_GRAMS_1LBS;
            TestContext.WriteLine($"{value}");
            General.HasTrueValue(value > 0, _errOut);
        }

        [TestMethod, TestCategory("Weight Values")]
        public void WEIGHT_GRAMS_OZ_Test()
        {
            var value = MLL.Global.WeightValues.WEIGHT_GRAMS_OZ;
            TestContext.WriteLine($"{value}");
            General.HasTrueValue(value > 0, _errOut);
        }
    }
}
