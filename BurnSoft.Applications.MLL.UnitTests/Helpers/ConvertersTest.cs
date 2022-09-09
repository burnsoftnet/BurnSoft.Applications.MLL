using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BurnSoft.Applications.MLL.Global;
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
        /// <summary>
        /// The convert ounces to double
        /// </summary>
        private string ConvertOuncesToDouble;
        /// <summary>
        /// The convert ounces to double expected
        /// </summary>
        private double ConvertOuncesToDoubleExpected;
        /// <summary>
        /// The convert weight
        /// </summary>
        private double ConvertWeight;
        /// <summary>
        /// The convert weight LBS to grains expected
        /// </summary>
        private double ConvertWeightLbsToGrainsExpected;
        /// <summary>
        /// The convert weight LBS to grams expected
        /// </summary>
        private double ConvertWeightLbsToGramsExpected;

        public double ConvertToDollars;

        public double ConvertToDollarsExpectedValue;
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
            ConvertWeight = Convert.ToDouble(Vs2019.GetSetting("ConvertWeight", TestContext));
            ConvertWeightLbsToGrainsExpected = Convert.ToDouble(Vs2019.GetSetting("ConvertWeightLbsToGrainsExpected", TestContext));
            ConvertWeightLbsToGramsExpected = Convert.ToDouble(Vs2019.GetSetting("ConvertWeightLbsToGramsExpected", TestContext));
            ConvertToDollars = Convert.ToDouble(Vs2019.GetSetting("ConvertToDollars", TestContext));
            ConvertToDollarsExpectedValue = Convert.ToDouble(Vs2019.GetSetting("ConvertToDollarsExpectedValue", TestContext));
        }
        /// <summary>
        /// Defines the test method ConvertToNumberTest.
        /// </summary>
        [TestMethod, TestCategory("Helpers - Converters")]
        public void ConvertToNumberTest()
        {
            double value = BurnSoft.Applications.MLL.Helpers.Converters.ConvertToNumber(ConverThisToNumber, out _errOut);
            TestContext.WriteLine($"RETURNED VALUE: {value}, expected: {ConverThisToNumberExpected}");
            General.HasTrueValue(value == ConverThisToNumberExpected, _errOut);
        }
        /// <summary>
        /// Defines the test method ConvertOuncesToDoubleTest.
        /// </summary>
        [TestMethod, TestCategory("Helpers - Converters")]
        public void ConvertOuncesToDoubleTest()
        {
            double value = BurnSoft.Applications.MLL.Helpers.Converters.ConvertOuncesToDouble(ConvertOuncesToDouble, out _errOut);
            TestContext.WriteLine($"RETURNED VALUE: {value}, explected {ConvertOuncesToDoubleExpected}");
            General.HasTrueValue(value == ConvertOuncesToDoubleExpected, _errOut);
        }
        /// <summary>
        /// Defines the test method ConvertWeightPoundsToGrainsTest.
        /// </summary>
        [TestMethod, TestCategory("Helpers - Converters")]
        public void ConvertWeightPoundsToGrainsTest()
        {
            double value = MLL.Helpers.Converters.ConvertWeight(ConvertWeight, WeightValues.WeightType.Grains, WeightValues.WeightType.Pounds, out _errOut);
            TestContext.WriteLine($"RETURNED VALUE: {value}, explected {ConvertWeightLbsToGrainsExpected} gn from {ConvertWeight} lbs");
            General.HasTrueValue(value == ConvertWeightLbsToGrainsExpected, _errOut);
        }
        /// <summary>
        /// Defines the test method ConvertWeightPoundsToGramsTest.
        /// </summary>
        [TestMethod, TestCategory("Helpers - Converters")]
        public void ConvertWeightPoundsToGramsTest()
        {
            double value = MLL.Helpers.Converters.ConvertWeight(ConvertWeight, WeightValues.WeightType.Grams, WeightValues.WeightType.Pounds, out _errOut);
            TestContext.WriteLine($"RETURNED VALUE: {value}, explected {ConvertWeightLbsToGramsExpected} grams from {ConvertWeight} lbs");
            General.HasTrueValue(value == ConvertWeightLbsToGramsExpected, _errOut);
        }

        [TestMethod, TestCategory("Helpers - Converters")]
        public void ConvertToDollarsTest()
        {
            double value = MLL.Helpers.Converters.ConvertToDollars(ConvertToDollars);
            TestContext.WriteLine($"RETURNED VALUE: {value}, explected {ConvertToDollarsExpectedValue} from {ConvertToDollars}");
            General.HasTrueValue(value == ConvertToDollarsExpectedValue, _errOut);
        }
    }
}
