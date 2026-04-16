using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class ShotgunGaugesTests
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
        /// The existing name
        /// </summary>
        private string _existingName;
        /// <summary>
        /// The existing identifier
        /// </summary>
        private int _existingId;
        /// <summary>
        /// The name
        /// </summary>
        private string _name;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingName = "12 Gauge";
            _existingId = 2;
            _name = "8 Gauge";
        }

        private void AddTestCasesExists()
        {
            if (!ShotgunGauges.DataExists(_databasePath, _name, out _))
            {
                ShotgunGauges.Add(_databasePath, _name, out _);
            }
        }

        private void DeleteTestCasesExists()
        {
            if (ShotgunGauges.DataExists(_databasePath, _name, out _))
            {
                long id = ShotgunGauges.GetId(_databasePath, _name, out _);
                ShotgunGauges.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCases(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ShotgunGaugeData> value = ShotgunGauges.GetDetails(_databasePath, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunGaugeDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunGaugeData> value = ShotgunGauges.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunGaugeDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestCasesExists();
                bool value = ShotgunGauges.Add(_databasePath, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ShotgunGauges.GetId(_databasePath, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunGaugeDataData(ShotgunGauges.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                PrintTestCases();
                long id = ShotgunGauges.GetId(_databasePath, _name, out _);
                bool value = ShotgunGauges.Update(_databasePath, id, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestCases("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                long id = ShotgunGauges.GetId(_databasePath, _name, out _);
                bool value = ShotgunGauges.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestCasesExists();
                bool value = ShotgunGauges.Delete(_databasePath, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = ShotgunGauges.GetId(_databasePath, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void GetNameTest()
        {
            bool bAns = false;
            try
            {
                string value = ShotgunGauges.GetName(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE RETURNED {value}, expected {_existingName}");
                bAns = value.Equals(_existingName);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunGaugeData> value = ShotgunGauges.GetDetails(_databasePath, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunGaugeDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<ShotgunGaugeData> value = ShotgunGauges.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunGaugeDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = ShotgunGauges.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Gauges")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = ShotgunGauges.DataExists(_databasePath, _existingName, out _errOut);
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
