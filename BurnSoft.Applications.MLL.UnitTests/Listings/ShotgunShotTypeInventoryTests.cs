using BurnSoft.Applications.MLL.Enums;
using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class ShotgunShotTypeInventoryTests
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


        private bool _isSlug;
        private string _materialUsed;

        private string _shotNumber;
        private string _weight;
        private string _caliber;
        private int _qty;
        private double _price;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _manufacturer = "Winchester";
            _name = "Lead ChilledShot";
            _isSlug = false;
            _materialUsed = "Lead/Zinc";
            _shotNumber = "7 1/2";
            _weight = "1 oz";
            _caliber = "12 Gauge";
            _qty = 1000;
            _price = 39.99;
        }

        private void AddTestDataExists()
        {
            if (!ShotgunShotTypeInventory.DataExists(_databasePath, _manufacturer, _name, _materialUsed, out _))
            {
                ShotgunShotTypeInventory.Add(_databasePath, _manufacturer, _name,
                    _materialUsed, _weight, _isSlug, _shotNumber, _caliber, _qty, _price, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (ShotgunShotTypeInventory.DataExists(_databasePath, _manufacturer, _name, _materialUsed, out _))
            {
                long id = ShotgunShotTypeInventory.GetId(_databasePath, _manufacturer, _name, _materialUsed, out _);
                ShotgunShotTypeInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestCases(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<ShotgunShotTypeData> value = ShotgunShotTypeInventory.GetDetails(_databasePath, _manufacturer, _name, _materialUsed, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunShotTypeDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<ShotgunShotTypeData> value = ShotgunShotTypeInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunShotTypeDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetWeightTypeOunces()
        {
            WeightTypes value = ShotgunShotTypeInventory.GetWeightType("1/2 oz");
            bool bAns = (value == WeightTypes.Ounces);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetWeightTypeOunces2()
        {
            WeightTypes value = ShotgunShotTypeInventory.GetWeightType("1/2 oz.");
            bool bAns = (value == WeightTypes.Ounces);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetWeightTypeGrains()
        {
            WeightTypes value = ShotgunShotTypeInventory.GetWeightType("1/2 gn");
            bool bAns = (value == WeightTypes.Grains);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetWeightTypeGrains2()
        {
            WeightTypes value = ShotgunShotTypeInventory.GetWeightType("1/2 gn.");
            bool bAns = (value == WeightTypes.Grains);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetWeightTypePound()
        {
            WeightTypes value = ShotgunShotTypeInventory.GetWeightType("1/2 lbs");
            bool bAns = (value == WeightTypes.Pound);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetWeightTypePound2()
        {
            WeightTypes value = ShotgunShotTypeInventory.GetWeightType("1/2 lbs.");
            bool bAns = (value == WeightTypes.Pound);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetWeightTypeGrams()
        {
            WeightTypes value = ShotgunShotTypeInventory.GetWeightType("1/2 gm");
            bool bAns = (value == WeightTypes.Grams);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetWeightTypeGrams2()
        {
            WeightTypes value = ShotgunShotTypeInventory.GetWeightType("1/2 Grams");
            bool bAns = (value == WeightTypes.Grams);
            General.HasTrueValue(bAns);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = ShotgunShotTypeInventory.Add(_databasePath, _manufacturer, _name,
                    _materialUsed, _weight, _isSlug, _shotNumber, _caliber, _qty, _price, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = ShotgunShotTypeInventory.GetId(_databasePath, _manufacturer, _name, _materialUsed, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunShotTypeDataData(
                    ShotgunShotTypeInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestCases();
                long id = ShotgunShotTypeInventory.GetId(_databasePath, _manufacturer, _name, _materialUsed, out _);
                bool value = ShotgunShotTypeInventory.Update(_databasePath, id, _manufacturer, _name,
                    _materialUsed, _weight, _isSlug, _shotNumber, _caliber, _qty * 2, _price, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = ShotgunShotTypeInventory.GetId(_databasePath, _manufacturer, _name, _materialUsed, out _);
                bool value = ShotgunShotTypeInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = ShotgunShotTypeInventory.Delete(_databasePath, _manufacturer, _name, _materialUsed, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = ShotgunShotTypeInventory.GetId(_databasePath, _manufacturer, _name, _materialUsed, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<ShotgunShotTypeData> value = ShotgunShotTypeInventory.GetDetails(_databasePath,
                    _manufacturer, _name, _materialUsed, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunShotTypeDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long _existingId = ShotgunShotTypeInventory.GetId(_databasePath, _manufacturer, _name, _materialUsed, out _errOut);
                List<ShotgunShotTypeData> value = ShotgunShotTypeInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.ShotgunShotTypeDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = ShotgunShotTypeInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Shotgun Shot Types")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = ShotgunShotTypeInventory.DataExists(_databasePath, _manufacturer, _name, _materialUsed, out _errOut);
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
