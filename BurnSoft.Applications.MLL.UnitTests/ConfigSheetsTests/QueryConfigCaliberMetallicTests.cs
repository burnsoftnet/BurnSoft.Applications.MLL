using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class QueryConfigCaliberMetallicTests
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
        /// The caliber identifier
        /// </summary>
        private long _caliberId;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingConfigName = "HL8007U";
            _existingId = 13;
            _caliberId = 4;
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigCaliberData> value = QueryConfigCaliberMetallic.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigCaliberMetallicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = QueryConfigCaliberMetallic.GetId(_databasePath, _existingConfigName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"ID RETURNED {value}, expected {_existingId}");
                bAns = (value == _existingId);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigCaliberData> value = QueryConfigCaliberMetallic.GetDetails(_databasePath, _existingConfigName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigCaliberMetallicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigCaliberData> value = QueryConfigCaliberMetallic.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigCaliberMetallicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data")]
        public void GetDetailsByCaliberIdTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigCaliberData> value = QueryConfigCaliberMetallic.GetDetailsByCaliberId(_databasePath, _caliberId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigCaliberMetallicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = QueryConfigCaliberMetallic.DataExists(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Metallic Query Data")]
        public void DataExistsByCaliberIdTest()
        {
            bool bAns = false;
            try
            {
                bool value = QueryConfigCaliberMetallic.DataExistsByCaliberId(_databasePath, _caliberId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
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
