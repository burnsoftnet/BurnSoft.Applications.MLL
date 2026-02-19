using BurnSoft.Applications.MLL.LoadersLog;
using BurnSoft.Applications.MLL.PeopleAndPlaces;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BurnSoft.Applications.MLL.UnitTests.LoadersLog
{
    [TestClass]
    public class FirearmsTests
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
        /// The manufaturer
        /// </summary>
        private string _manufaturer;
        /// <summary>
        /// The model
        /// </summary>
        private string _model;
        /// <summary>
        /// The serial number
        /// </summary>
        private string _serialNumber;
        /// <summary>
        /// The barrel
        /// </summary>
        private string _barrel;
        /// <summary>
        /// The exclude
        /// </summary>
        private bool _exclude;
        /// <summary>
        /// The firearm type
        /// </summary>
        private string _firearmType;
        /// <summary>
        /// The caliber
        /// </summary>
        private string _caliber;
        /// <summary>
        /// The full name
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _manufaturer = "Generic";
            _model = "Pistol";
            _fullName = $"{_manufaturer} {_model}";
            _caliber = "9mm Luger";
            _serialNumber = "THS23424234";
            _barrel = "5\"";
            _exclude = false;
            _firearmType = "Pistol: Semi-Auto";
        }

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<FirearmCollection> value = Firearms.GetDetails(_databasePath, 13, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.FirearmCollectionData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<FirearmCollection> value = Firearms.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.FirearmCollectionData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        private void AddTestFirearmExists()
        {
            if (!Firearms.DataExists(_databasePath, _fullName, out _))
            {
                Firearms.Add(_databasePath, _manufaturer, _model,
                    _serialNumber, _caliber, _firearmType, _barrel, 
                    out _, exclude: _exclude);
            }
        }

        private void DeleteTestFirearmExists()
        {
            if (Firearms.DataExists(_databasePath, _fullName, out _))
            {
                long id = Firearms.GetId(_databasePath, _fullName, out _);
                Firearms.Delete(_databasePath, id, out _);
            }
        }

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void GetDetailsFulleNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestFirearmExists();
                List<FirearmCollection> value = Firearms.GetDetails(_databasePath, _fullName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.FirearmCollectionData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestFirearmExists();
                long value = Firearms.GetId(_databasePath, _fullName, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = Firearms.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void DataExistsFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestFirearmExists();
                bool value = Firearms.DataExists(_databasePath, _fullName, out _errOut);
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

        private void PrintTestFirearm(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<FirearmCollection> value = Firearms.GetDetails(_databasePath, _fullName, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.FirearmCollectionData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestFirearmExists();
                bool value = Firearms.Add(_databasePath, _manufaturer, _model,
                    _serialNumber, _caliber, _firearmType, _barrel,
                    out _errOut, exclude: _exclude);
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

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestFirearmExists();
                PrintTestFirearm();
                long id = Firearms.GetId(_databasePath, _fullName, out _);
                bool value = Firearms.Update(_databasePath, id, _manufaturer, _model,
                    _serialNumber, _caliber, $"{_firearmType} w/ switch", _barrel,
                    out _errOut, exclude: _exclude);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = true;
                PrintTestFirearm("AFTER");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestFirearmExists();
                long id = Firearms.GetId(_databasePath, _fullName, out _);
                bool value = Firearms.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Loaders Log - Firearms")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestFirearmExists();
                bool value = Firearms.Delete(_databasePath, _fullName, out _errOut);
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
