using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class AmmuntionTypeTests
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
        /// The existing identifier
        /// </summary>
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
            _existingName = "Pistol";
            _existingId = 1;
            _name = "Shotgun Pistol";
        }

        private void AddTestCaliberExists()
        {
            if (!AmmuntionType.DataExists(_databasePath, _name, out _))
            {
                AmmuntionType.Add(_databasePath, _name, out _);
            }
        }

        private void DeleteTestCaliberExists()
        {
            if (AmmuntionType.DataExists(_databasePath, _name, out _))
            {
                long id = AmmuntionType.GetId(_databasePath, _name, out _);
                AmmuntionType.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCalibers(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<AmmuntionTypeListings> value = AmmuntionType.GetAll(_databasePath, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.AmmuntionTypeListingsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<AmmuntionTypeListings> value = AmmuntionType.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.AmmuntionTypeListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestCaliberExists();
                bool value = AmmuntionType.Add(_databasePath, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = AmmuntionType.GetId(_databasePath, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.AmmuntionTypeListingsData(AmmuntionType.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestCaliberExists();
                PrintTestCalibers();
                long id = AmmuntionType.GetId(_databasePath, _name, out _);
                bool value = AmmuntionType.Update(_databasePath, id, $"{_name} hybrid", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestCalibers("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestCaliberExists();
                long id = AmmuntionType.GetId(_databasePath, _name, out _);
                bool value = AmmuntionType.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestCaliberExists();
                bool value = AmmuntionType.Delete(_databasePath, _name, out _errOut);
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

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = AmmuntionType.GetId(_databasePath, _existingName, out _errOut);
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

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<AmmuntionTypeListings> value = AmmuntionType.GetDetails(_databasePath, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.AmmuntionTypeListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<AmmuntionTypeListings> value = AmmuntionType.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.AmmuntionTypeListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = AmmuntionType.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void GetAmmoTypeTest()
        {
            bool bAns = false;
            try
            {
                string value = AmmuntionType.GetAmmoType(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                bAns = value.Length > 0;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("General Listings - Ammo Type")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = AmmuntionType.DataExists(_databasePath, _existingName, out _errOut);
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
