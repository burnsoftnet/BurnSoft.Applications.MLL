using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.ConfigSheetsTests
{
    [TestClass]
    public class QueryConfigCaliberShotgunTest
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
            _existingConfigName = "Alliant 20GA 2 3/4\" 2 1/2 Dram.";
            _existingId = 21;
            _caliberId = 1;
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Query Data")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigCaliberShotgunData> value = QueryConfigCaliberShotgun.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigCaliberShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Query Data")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = QueryConfigCaliberShotgun.GetId(_databasePath, _existingConfigName, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Query Data")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigCaliberShotgunData> value = QueryConfigCaliberShotgun.GetDetails(_databasePath, _existingConfigName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigCaliberShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Query Data")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigCaliberShotgunData> value = QueryConfigCaliberShotgun.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigCaliberShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Query Data")]
        public void GetDetailsByCaliberIdTest()
        {
            bool bAns = false;
            try
            {
                List<QueryConfigCaliberShotgunData> value = QueryConfigCaliberShotgun.GetDetailsByCaliberId(_databasePath, _caliberId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.QueryConfigCaliberShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Config Sheets - Shotgun Query Data")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = QueryConfigCaliberShotgun.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Config Sheets - Shotgun Query Data")]
        public void DataExistsByCaliberIdTest()
        {
            bool bAns = false;
            try
            {
                bool value = QueryConfigCaliberShotgun.DataExistsByCaliberId(_databasePath, _caliberId, out _errOut);
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
