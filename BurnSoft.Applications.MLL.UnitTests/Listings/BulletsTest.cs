using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class BulletsTest
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
        /// The existing manu
        /// </summary>
        private string _existingManu;
        /// <summary>
        /// The existing name
        /// </summary>
        private string _existingName;
        /// <summary>
        /// The existing identifier
        /// </summary>
        private int _existingId;
        /// <summary>
        /// The manufacturer
        /// </summary>
        private string _manufacturer;
        /// <summary>
        /// The name
        /// </summary>
        private string _name;
        /// <summary>
        /// The diameter
        /// </summary>
        private string _diameter;
        /// <summary>
        /// The weight
        /// </summary>
        private string _weight;
        /// <summary>
        /// The sectional density
        /// </summary>
        private string _sectionalDensity;
        /// <summary>
        /// The part number
        /// </summary>
        private string _partNumber;
        /// <summary>
        /// The bc
        /// </summary>
        private string _bc;
        /// <summary>
        /// The bullet type
        /// </summary>
        private int _bulletType;
        /// <summary>
        /// The qty
        /// </summary>
        private int _qty;
        /// <summary>
        /// The price
        /// </summary>
        private double _price;
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
            _existingManu = "Hornady";
            _existingName = "Full Metal Jacket 115 gr.";
            _existingId = 3;
            _manufacturer = "The Blue Bullets";
            _name = "BlueBullets 147g RN";
            _diameter = "0.355";
            _weight = "147 grains";
            _sectionalDensity = "1.0";
            _partNumber = "234234234234";
            _bc = ".123";
            _bulletType = 1;
            _qty = 1200;
            _price = 69.00;
            _caliberId = 1;
        }

        private void AddTestBulletsExists()
        {
            if (!BulletsInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                BulletsInventory.Add(_databasePath, _manufacturer, _name,
                    _diameter, _weight, _sectionalDensity, _partNumber, _bc,
                    _bulletType, _qty, _price, _caliberId, out _);
            }
        }

        private void DeleteTestBulletsExists()
        {
            if (BulletsInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                long id = BulletsInventory.GetId(_databasePath, _manufacturer, _name, out _);
                BulletsInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestBullets(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<BulletListings> value = BulletsInventory.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.BulletListingsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<BulletListings> value = BulletsInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.BulletListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestBulletsExists();
                bool value = BulletsInventory.Add(_databasePath, _manufacturer, _name, 
                    _diameter, _weight, _sectionalDensity, _partNumber, _bc, 
                    _bulletType, _qty, _price, _caliberId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = BulletsInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.BulletListingsData(BulletsInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestBulletsExists();
                PrintTestBullets();
                long id = BulletsInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = BulletsInventory.Update(_databasePath, id, _manufacturer, _name,
                    _diameter, _weight, _sectionalDensity, _partNumber, _bc,
                    _bulletType, (_qty * 2), _price, _caliberId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestBullets("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void UpdateQtyTest()
        {
            bool bAns = false;
            try
            {
                AddTestBulletsExists();
                PrintTestBullets();
                long id = BulletsInventory.GetId(_databasePath, _manufacturer, _name, out _);

                double currentPrice = 0;
                int currentQty = 0;
                double currentPricePerItenm = 0;
                List<BulletListings> lst = BulletsInventory.GetDetails(_databasePath, id, out _);

                foreach (BulletListings l in lst)
                {
                    currentPrice = l.Price;
                    currentQty = l.Qty;
                    currentPricePerItenm = l.EsitmatedPricePerBullet;
                }

                bool value = BulletsInventory.UpdateQty(_databasePath, id, currentQty, currentPrice,
                    currentPricePerItenm, 1000, 20.00,  out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestBullets("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestBulletsExists();
                long id = BulletsInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = BulletsInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestBulletsExists();
                bool value = BulletsInventory.Delete(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = BulletsInventory.GetId(_databasePath, _existingManu, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void GetNameTest()
        {
            bool bAns = false;
            try
            {
                string value = BulletsInventory.GetName(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE RETURNED {value}");
                bAns = (value.Length > 0);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<BulletListings> value = BulletsInventory.GetDetails(_databasePath, _existingManu, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.BulletListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<BulletListings> value = BulletsInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.BulletListingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = BulletsInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Bullets")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = BulletsInventory.DataExists(_databasePath, _existingManu, _existingName, out _errOut);
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
