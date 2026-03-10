using BurnSoft.Applications.MLL.LoadersLog;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.LoadersLog
{
    [TestClass]
    public class LoadersLogAmmunitionAuditAuditTests
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

        private int _existingConfigId;
        
        private int _configId;
        
        private string _dateCreated;
        
        private long _qty;

        private double _estimatedCostToMake;

        private double _estimatedCostPerRound;
        
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingConfigId = 20;
            _configId = 17;
            _dateCreated = "9/25/2026 10:03:13 AM";
            _qty = 1200;
            _estimatedCostToMake = 120.35;
            _estimatedCostPerRound = (_estimatedCostToMake / _qty);
        }

        private void AddTestDataExists()
        {
            if (!LoadersLogAmmunitionAudit.DataExists(_databasePath, _configId, out _))
            {
                LoadersLogAmmunitionAudit.Add(_databasePath, _configId, _dateCreated,
                    _qty, _estimatedCostToMake, _estimatedCostPerRound, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (LoadersLogAmmunitionAudit.DataExists(_databasePath, _configId, out _))
            {
                long id = LoadersLogAmmunitionAudit.GetId(_databasePath, _configId, out _);
                LoadersLogAmmunitionAudit.Delete(_databasePath, id, out _);
            }
        }

        private void PrintData(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<LoadersLogAmmunitionAuditData> value = LoadersLogAmmunitionAudit.GetDetails(_databasePath, _configId, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionAuditDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<LoadersLogAmmunitionAuditData> value = LoadersLogAmmunitionAudit.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionAuditDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = LoadersLogAmmunitionAudit.Add(_databasePath, _configId, _dateCreated,
                    _qty, _estimatedCostToMake, _estimatedCostPerRound, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = LoadersLogAmmunitionAudit.GetId(_databasePath, _configId, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionAuditDataData(LoadersLogAmmunitionAudit.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintData();
                long id = LoadersLogAmmunitionAudit.GetId(_databasePath, _configId, out _);
                bool value = LoadersLogAmmunitionAudit.Update(_databasePath, id, _configId, _dateCreated,
                    _qty, _estimatedCostToMake + 15.24, _estimatedCostPerRound, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintData("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = LoadersLogAmmunitionAudit.GetId(_databasePath, _configId, out _);
                bool value = LoadersLogAmmunitionAudit.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogAmmunitionAudit.Delete(_databasePath, _configId, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = LoadersLogAmmunitionAudit.GetId(_databasePath, _configId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"ID RETURNED {value}");
                bAns = (value > 0);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<LoadersLogAmmunitionAuditData> value = LoadersLogAmmunitionAudit.GetDetails(_databasePath, _configId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionAuditDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = LoadersLogAmmunitionAudit.GetId(_databasePath, _configId, out _errOut);
                List<LoadersLogAmmunitionAuditData> value = LoadersLogAmmunitionAudit.GetDetails(_databasePath, id, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionAuditDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogAmmunitionAudit.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Ammunition Audit")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogAmmunitionAudit.DataExists(_databasePath, _configId, out _errOut);
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
