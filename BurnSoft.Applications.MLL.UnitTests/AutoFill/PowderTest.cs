using BurnSoft.Applications.MLL.AutoFill;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.UnitTests.AutoFill
{
    [TestClass]
    public class PowderTest
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
        [TestMethod, TestCategory("AutoFill - Powder")]
        public void PowderNameTest()
        {
            AutoCompleteStringCollection value = Powder.PowderName(_databasePath, out _errOut);
            foreach (var a in value)
            {
                TestContext.WriteLine(a.ToString());
            }
            General.HasTrueValue(value.Count > 0, _errOut);
        }
    }
}
