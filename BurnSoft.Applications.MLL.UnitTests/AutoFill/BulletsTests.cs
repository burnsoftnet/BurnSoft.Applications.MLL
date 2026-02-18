using BurnSoft.Applications.MLL.AutoFill;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.UnitTests.AutoFill
{
    [TestClass]
    public class BulletsTests
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
        /// <summary>
        /// Defines the test method ModelTest.
        /// </summary>
        [TestMethod, TestCategory("AutoFill - Bullets")]
        public void NameTest()
        {
            AutoCompleteStringCollection value = Bullets.Name(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Bullets")]
        public void ManufacturerTest()
        {
            AutoCompleteStringCollection value = Bullets.Manufacturer(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Bullets")]
        public void PriceTest()
        {
            AutoCompleteStringCollection value = Bullets.Price(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Bullets")]
        public void DiameterTest()
        {
            AutoCompleteStringCollection value = Bullets.Diameter(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Bullets")]
        public void SectionalDensityTest()
        {
            AutoCompleteStringCollection value = Bullets.SectionalDensity(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Bullets")]
        public void PartNumberTest()
        {
            AutoCompleteStringCollection value = Bullets.PartNumber(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Bullets")]
        public void BallisticCoefficientTest()
        {
            AutoCompleteStringCollection value = Bullets.BallisticCoefficient(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }

        [TestMethod, TestCategory("AutoFill - Bullets")]
        public void WeightTest()
        {
            AutoCompleteStringCollection value = Bullets.Weight(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
