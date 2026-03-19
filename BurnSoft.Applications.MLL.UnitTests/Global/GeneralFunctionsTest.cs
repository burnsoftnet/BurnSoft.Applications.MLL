using BurnSoft.Applications.MLL.Global;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BurnSoft.Applications.MLL.UnitTests.Global
{
    [TestClass]
    public class GeneralFunctionsTest
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

        [TestMethod, TestCategory("General Functions")]
        public void CountFirearmsTest()
        {
            int value = GeneralFunctions.CountFirearms(_databasePath, out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            if ( value == 0 ) Assert.Fail();
            if (_errOut.Length > 0 ) Assert.Fail();
        }

        [TestMethod, TestCategory("General Functions")]
        public void CountReadyToUseAmmoTest()
        {
            long value = GeneralFunctions.CountReadyToUseAmmo(_databasePath, out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            if (value == 0) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }

        [TestMethod, TestCategory("General Functions")]
        public void GetTitleTest()
        {
            string value = GeneralFunctions.GetTitle(_databasePath, 4, out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            if (value.Length == 0) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }

        [TestMethod, TestCategory("General Functions")]
        public void GetAmmoTypeIDTest()
        {
            long value = GeneralFunctions.GetAmmoTypeID(_databasePath, "Pistol", out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            if (value == 0) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }

        [TestMethod, TestCategory("General Functions")]
        public void GetAmmoTypeIDSGTest()
        {
            long value = GeneralFunctions.GetAmmoTypeIDSG(_databasePath, "Field Loads", out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            if (value == 0) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }

        [TestMethod, TestCategory("General Functions")]
        public void GetAmmoTypeNameShotGunTest()
        {
            string value = GeneralFunctions.GetAmmoTypeNameShotGun(_databasePath, 1, out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            if (value.Length == 0) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }

        [TestMethod, TestCategory("General Functions")]
        public void GetCaliberIDTest()
        {
            long value = GeneralFunctions.GetCaliberID(_databasePath, ".380 ACP", out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            if (value == 0) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }

        [TestMethod, TestCategory("General Functions")]
        public void GetCaliberIDAddTest()
        {
            long value = GeneralFunctions.GetCaliberID(_databasePath, "6.5 ARC", out _errOut, AutoAdd: true);
            TestContext.WriteLine($"VALUE: {value}");
            if (value == 0) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }

        [TestMethod, TestCategory("General Functions")]
        public void TotalCostEquipmentTest()
        {
            long value = GeneralFunctions.TotalCostEquipment(_databasePath, out _errOut);
            TestContext.WriteLine($"VALUE: {value}");
            if (value == 0) Assert.Fail();
            if (_errOut.Length > 0) Assert.Fail();
        }
    }
}
