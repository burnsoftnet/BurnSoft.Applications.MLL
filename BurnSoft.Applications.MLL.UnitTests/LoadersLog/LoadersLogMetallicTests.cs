using BurnSoft.Applications.MLL.LoadersLog;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.LoadersLog
{
    [TestClass]
    public class LoadersLogMetallicTests
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
        /// The existing configuration id
        /// </summary>
        private int _existingConfigId;
        /// <summary>
        /// The firearm identifier
        /// </summary>
        private long _firearmId;
        /// <summary>
        /// The date created
        /// </summary>
        private string _dateCreated;
        /// <summary>
        /// The yards
        /// </summary>
        private int _yards;

        private string _groupSize;

        private int _numberOfShots;

        private string _powderDetails;

        private string _bulletDetails;

        private string _primerDetails;
        private string _caseDetails;
        private string _condition;
        private string _oal;
        private string _notes;
        private string _configName;
        private string _FirearmName;
        private string _caliber;
        private string _BarrelLenght;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingConfigId = 9;
            _firearmId = 13;
            _dateCreated = DateTime.Now.ToString();
            _bulletDetails = "TheBlueBullets - 147g";
            _yards = 15;
            _groupSize = "1.5 MOA";
            _numberOfShots = 10;
            _powderDetails = "HS 6 - 6.7 - Hodgdon";
            _primerDetails = "CCI 200";
            _caseDetails = "Mixed Win 9mm, Fed 9mm, CCI 9mm, S&B 9mm (NEW)";
            _condition = "Cold";
            _oal = "1.10\"";
            _notes = "Power Factor of 128";
            _configName = "HL8003U";
            _FirearmName = "Glock G17";
            _caliber = "9mm Luger";
            _BarrelLenght = "5\"";
        }

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<LoadersLogMetallicData> value = LoadersLogMetallic.GetDetails(_databasePath, _existingConfigId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogMetallicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<LoadersLogMetallicData> value = LoadersLogMetallic.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogMetallicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        private void AddTestDataExists()
        {
            if (!LoadersLogMetallic.DataExists(_databasePath, _configName, _dateCreated, out _))
            {
                LoadersLogMetallic.Add(_databasePath, _firearmId, _dateCreated,
                    _yards, _groupSize, _numberOfShots, _powderDetails, 
                    _bulletDetails, _primerDetails, _caseDetails, _condition, 
                    _oal, _notes, _configName, _FirearmName, _caliber, _BarrelLenght, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (LoadersLogMetallic.DataExists(_databasePath, _configName, _dateCreated, out _))
            {
                long id = LoadersLogMetallic.GetId(_databasePath, _configName, _dateCreated, out _);
                LoadersLogMetallic.Delete(_databasePath, id, out _);
            }
        }

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void GetDetailsFulleNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<LoadersLogMetallicData> value = LoadersLogMetallic.GetDetails(_databasePath, _configName, _dateCreated, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogMetallicDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = LoadersLogMetallic.GetId(_databasePath, _configName, _dateCreated, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = LoadersLogMetallic.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void DataExistsFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogMetallic.DataExists(_databasePath, _configName, _dateCreated, out _errOut);
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

        private void PrintTestData(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<LoadersLogMetallicData> value = LoadersLogMetallic.GetDetails(_databasePath, _configName, _dateCreated, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogMetallicDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = LoadersLogMetallic.Add(_databasePath, _firearmId, _dateCreated,
                    _yards, _groupSize, _numberOfShots, _powderDetails,
                    _bulletDetails, _primerDetails, _caseDetails, _condition,
                    _oal, _notes, _configName, _FirearmName, _caliber, _BarrelLenght, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestData();
                long id = LoadersLogMetallic.GetId(_databasePath, _configName, _dateCreated, out _);
                bool value = LoadersLogMetallic.Update(_databasePath, id, _firearmId, _dateCreated,
                    _yards, _groupSize, _numberOfShots, _powderDetails,
                    _bulletDetails, _primerDetails, _caseDetails, _condition + " and snowy",
                    _oal, _notes, _configName, _FirearmName, _caliber, _BarrelLenght,
                    out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = true;
                PrintTestData("AFTER");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = LoadersLogMetallic.GetId(_databasePath, _configName, _dateCreated, out _);
                bool value = LoadersLogMetallic.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Metalic Log")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogMetallic.Delete(_databasePath, _configName, _dateCreated, out _errOut);
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
