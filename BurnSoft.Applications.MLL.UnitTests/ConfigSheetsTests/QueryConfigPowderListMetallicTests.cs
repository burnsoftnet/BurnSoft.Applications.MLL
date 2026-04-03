using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class QueryConfigPowderListMetallicTests
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
        /// The existing configuration name
        /// </summary>
        private string _existingConfigName;
        /// <summary>
        /// The existing identifier
        /// </summary>
        private int _existingId;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingConfigName = "HL8014U";
            _existingId = 4;
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data All")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigPowderListData> value = QueryConfigPowderListMetallic.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigPowderListDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data All")]
        public void GetDetailsByNameTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigPowderListData> value = QueryConfigPowderListMetallic.GetDetails(_databasePath, 
                    _existingConfigName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigPowderListDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data All")]
        public void GetDetailsByIdTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigPowderListData> value = QueryConfigPowderListMetallic.GetDetails(_databasePath,
                    _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigPowderListDataData(value));
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
