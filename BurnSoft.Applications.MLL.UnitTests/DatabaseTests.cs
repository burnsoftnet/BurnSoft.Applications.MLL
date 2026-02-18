using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Versioning;

namespace BurnSoft.Applications.MLL.UnitTests
{
    [TestClass]
    public class DatabaseTests
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

        [TestMethod, TestCategory("Database")]
        public void GetDatabaseVersionTest()
        {
            bool bAns = false;
            try
            {
                double version = Database.GetDatabaseVersion(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"DB VERSION: {version}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex}");
            }

            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Database")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                string sql = $"SELECT * from Config_list_Name where ConfigName='HL8010U'";
                long version = Database.GetId(_databasePath, sql, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"ID VALUE: {version}");
                bAns = version == 16;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex}");
            }

            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Database")]
        public void GetNameTest()
        {
            bool bAns = false;
            try
            {
                string sql = $"SELECT * from Config_list_Name where ID=15";
                string value = Database.GetName(_databasePath, sql, "ConfigName", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = value.Length > 0;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex}");
            }

            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Database")]
        public void ObjectExistsInDbStringTest()
        {
            bool bAns = false;
            try
            {
                bool value = Database.ObjectExistsInDb(_databasePath, "ConfigName", "Config_List_Name", "HL8010U", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"Object Exists: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex}");
            }

            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Database")]
        public void ObjectExistsInDbIntTest()
        {
            bool bAns = false;
            try
            {
                bool value = Database.ObjectExistsInDb(_databasePath, "IsPersonal", "Config_List_Name", 1, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"Object Exists: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex}");
            }

            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Database")]
        public void ObjectExistsInDbIntFalseTest()
        {
            bool bAns = false;
            try
            {
                bool value = Database.ObjectExistsInDb(_databasePath, "IsPersonal", "Config_List_Name", 4, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"Object Exists: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine($"ERROR: {ex}");
            }

            General.HasTrueValue(bAns, _errOut);
        }
    }
}
