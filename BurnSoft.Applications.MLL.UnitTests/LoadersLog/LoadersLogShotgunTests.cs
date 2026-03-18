using BurnSoft.Applications.MLL.LoadersLog;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BurnSoft.Applications.MLL.UnitTests.LoadersLog
{
    [TestClass]
    public class LoadersLogShotgunTests
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
        /// <summary>
        /// The powder details
        /// </summary>
        private string _powderDetails;
        /// <summary>
        /// The primer details
        /// </summary>
        private string _patterDensity;
        /// <summary>
        /// The case details
        /// </summary>
        private string _caseDetails;
        /// <summary>
        /// The notes
        /// </summary>
        private string _notes;
        /// <summary>
        /// The configuration name
        /// </summary>
        private string _configName;
        /// <summary>
        /// The firearm name
        /// </summary>
        private string _FirearmName;
        /// <summary>
        /// The caliber
        /// </summary>
        private string _caliber;
        /// <summary>
        /// The barrel lenght
        /// </summary>
        private string _BarrelLenght;
        /// <summary>
        /// The primer details
        /// </summary>
        private string _primerDetails;
        /// <summary>
        /// The shot weight
        /// </summary>
        private string _shotWeight;
        /// <summary>
        /// The shot size
        /// </summary>
        private string _shotSize;
        /// <summary>
        /// The wad details
        /// </summary>
        private string _wadDetails;


        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {

            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingConfigId = 21;
            _firearmId = 13;
            _dateCreated = DateTime.Now.ToString();
            _wadDetails = "Winchester - WAA12F114 (yellow)";
            _yards = 15;
            _shotWeight = "1⅛ oz.";
            _shotSize = "No. 7";
            _powderDetails = "HS 6 - 6.7 - Hodgdon";
            _primerDetails = "Federal 150";
            _caseDetails = "Winchester - Plastic Shells with Plastic Basewad";
            _notes = "Sport Shot";
            _configName = "SG12.0001U";
            _FirearmName = "Puma Over Under";
            _caliber = "12 GA";
            _BarrelLenght = "22\"";
            _patterDensity = "6 inches";
        }

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<LoadersLogShotgunData> value = LoadersLogShotgun.GetDetails(_databasePath, _existingConfigId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
            
                List<LoadersLogShotgunData> value = LoadersLogShotgun.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogShotgunDataData(value));
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
            if (!LoadersLogShotgun.DataExists(_databasePath, _configName, _dateCreated, out _))
            {
                LoadersLogShotgun.Add(_databasePath, _firearmId, _FirearmName, _caliber, _BarrelLenght, 
                    _configName, _dateCreated, _shotWeight, _shotSize, _caseDetails, _powderDetails,
                    _wadDetails, _primerDetails, _patterDensity, _yards, _notes, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (LoadersLogShotgun.DataExists(_databasePath, _configName, _dateCreated, out _))
            {
                long id = LoadersLogShotgun.GetId(_databasePath, _configName, _dateCreated, out _);
                LoadersLogShotgun.Delete(_databasePath, id, out _);
            }
        }

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void GetDetailsConfigDateCreatedTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<LoadersLogShotgunData> value = LoadersLogShotgun.GetDetails(_databasePath, _configName, _dateCreated, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogShotgunDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = LoadersLogShotgun.GetId(_databasePath, _configName, _dateCreated, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = LoadersLogShotgun.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void DataExistsConfigDateCreatedTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogShotgun.DataExists(_databasePath, _configName, _dateCreated, out _errOut);
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
            List<LoadersLogShotgunData> value = LoadersLogShotgun.GetDetails(_databasePath, _configName, _dateCreated, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogShotgunDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = LoadersLogShotgun.Add(_databasePath, _firearmId, _FirearmName, _caliber, _BarrelLenght,
                    _configName, _dateCreated, _shotWeight, _shotSize, _caseDetails, _powderDetails,
                    _wadDetails, _primerDetails, _patterDensity, _yards, _notes, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestData();
                long id = LoadersLogShotgun.GetId(_databasePath, _configName, _dateCreated, out _);
                bool value = LoadersLogShotgun.Update(_databasePath, id, _firearmId, _FirearmName, _caliber, _BarrelLenght,
                    _configName, _dateCreated, _shotWeight, _shotSize, _caseDetails, _powderDetails,
                    _wadDetails, _primerDetails, _patterDensity, _yards, _notes + " and Hunting",
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

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = LoadersLogShotgun.GetId(_databasePath, _configName, _dateCreated, out _);
                bool value = LoadersLogShotgun.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Shotgun Log")]
        public void DeleteByConfigDateCreatedTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogShotgun.Delete(_databasePath, _configName, _dateCreated, out _errOut);
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
