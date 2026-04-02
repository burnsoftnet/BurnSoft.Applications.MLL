using BurnSoft.Applications.MLL.Helpers;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BurnSoft.Applications.MLL.UnitTests.Helpers
{
    [TestClass]
    public class GeneralCalculationsTests
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
            // Vs2019.GetSetting("", TestContext);
            _errOut = @"";
        }

        [TestMethod, TestCategory("Helpers - Calculations")]
        public void CalculateMetallicRoundsToMakeTest()
        {
            long ConverThisToNumberExpected = 640;
            long roundsCanMake = GeneralCalculations.CalculateMetallicRoundsToMake(bulletQty: 1140, caseQty: 2000, primerQty: 640,
                powderQty: 4981.99, powderMidRangeLoad: 5.6, out _errOut);
            TestContext.WriteLine($"RETURNED VALUE: {roundsCanMake}, expected: {ConverThisToNumberExpected}");
            General.HasTrueValue(roundsCanMake == ConverThisToNumberExpected, _errOut);
        }
    }
}
