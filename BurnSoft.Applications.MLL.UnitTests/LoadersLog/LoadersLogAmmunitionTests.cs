using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.LoadersLog;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.LoadersLog
{
    [TestClass]
    public class LoadersLogAmmunitionTests
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
        /// The manufacturer
        /// </summary>
        private string _manufacturer;
        /// <summary>
        /// The name
        /// </summary>
        private string _name;
        /// <summary>
        /// The caliber
        /// </summary>
        private string _caliber;
        /// <summary>
        /// The grain
        /// </summary>
        private string _grain;
        /// <summary>
        /// The jacket
        /// </summary>
        private string _jacket;
        /// <summary>
        /// The qty
        /// </summary>
        private long _qty;
        /// <summary>
        /// The velocity
        /// </summary>
        private int _velocity;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _manufacturer = "Unit Test";
            _name = "UT 9mm Tree Spliter";
            _caliber = "9mm Luger";
            _grain = "150 grains";
            _jacket = "Rare Earth Metal Alloy";
            _qty = 1000;
            _velocity = 1500;
        }

        private void AddTestDataExists()
        {
            if (!LoadersLogAmmunition.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                LoadersLogAmmunition.Add(_databasePath, _manufacturer, _name,
                    _caliber, _grain, _jacket, _qty, _velocity, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (LoadersLogAmmunition.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                long id = LoadersLogAmmunition.GetId(_databasePath, _manufacturer, _name, out _);
                LoadersLogAmmunition.Delete(_databasePath, id, out _);
            }
        }

        private void PrintData(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<LoadersLogAmmunitionData> value = LoadersLogAmmunition.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<LoadersLogAmmunitionData> value = LoadersLogAmmunition.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = LoadersLogAmmunition.Add(_databasePath, _manufacturer, _name,
                    _caliber, _grain, _jacket, _qty, _velocity, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = LoadersLogAmmunition.GetId(_databasePath, _manufacturer, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionDataData(LoadersLogAmmunition.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void IsAlreadyListedTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = LoadersLogAmmunition.GetId(_databasePath, _manufacturer, _name, out _errOut);
                bool value = LoadersLogAmmunition.IsAlreadyListed(_databasePath, _manufacturer, _name, 
                    _caliber, _grain, _jacket, out _errOut, out var qty, out var ammoId);
                TestContext.WriteLine($"VALUE: {value}");
                TestContext.WriteLine($"qty: {qty}");
                TestContext.WriteLine($"ammoId: {ammoId}");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintData();
                long id = LoadersLogAmmunition.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = LoadersLogAmmunition.Update(_databasePath, id, _manufacturer, _name,
                    _caliber, _grain, _jacket, _qty * 2, _velocity, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = LoadersLogAmmunition.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = LoadersLogAmmunition.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogAmmunition.Delete(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = LoadersLogAmmunition.GetId(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<LoadersLogAmmunitionData> value = LoadersLogAmmunition.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = LoadersLogAmmunition.GetId(_databasePath, _manufacturer, _name, out _errOut);
                List<LoadersLogAmmunitionData> value = LoadersLogAmmunition.GetDetails(_databasePath, id, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoadersLogAmmunitionDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogAmmunition.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Ammunition")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = LoadersLogAmmunition.DataExists(_databasePath, _manufacturer, _name, out _errOut);
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
