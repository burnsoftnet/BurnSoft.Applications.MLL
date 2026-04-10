using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Listings
{
    [TestClass]
    public class EquipmentInventoryTests
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
        /// The use
        /// </summary>
        private string _use;
        /// <summary>
        /// The cost
        /// </summary>
        private double _cost;
        /// <summary>
        /// The notes
        /// </summary>
        private string _notes;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _existingManu = "RCBS";
            _existingName = "3 Piece 9mm Carb Die Set";
            _existingId = 2;
            _manufacturer = "RCBS";
            _name = "4 Piece 9mm Carb Die Competition Set";
            _use = "9mm Dies Set";
            _cost = 59.99;
            _notes = "Geared for performance in competition";

        }

        private void AddTestEquipmentExists()
        {
            if (!EquipmentInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                EquipmentInventory.Add(_databasePath, _manufacturer, _name,
                    _use, _cost, _notes, out _);
            }
        }

        private void DeleteTestEquipmentExists()
        {
            if (EquipmentInventory.DataExists(_databasePath, _manufacturer, _name, out _))
            {
                long id = EquipmentInventory.GetId(_databasePath, _manufacturer, _name, out _);
                EquipmentInventory.Delete(_databasePath, id, out _);
            }
        }

        private void PrintTestEquipment(string BeforeAfter = "BEFORE")
        {
            TestContext.WriteLine($"===========${BeforeAfter}===========");
            TestContext.WriteLine($"");
            List<EquipmentLists> value = EquipmentInventory.GetDetails(_databasePath, _manufacturer, _name, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.EquipmentListsData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                List<EquipmentLists> value = EquipmentInventory.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.EquipmentListsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestEquipmentExists();
                bool value = EquipmentInventory.Add(_databasePath, _manufacturer, _name,
                    _use, _cost, _notes, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                long id = EquipmentInventory.GetId(_databasePath, _manufacturer, _name, out _errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.EquipmentListsData(EquipmentInventory.GetDetails(_databasePath, id, out _errOut)));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestEquipmentExists();
                PrintTestEquipment();
                long id = EquipmentInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = EquipmentInventory.Update(_databasePath, id, _manufacturer, _name,
                    _use, (_cost * 2), _notes, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE: {value}");
                PrintTestEquipment("AFTER");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestEquipmentExists();
                long id = EquipmentInventory.GetId(_databasePath, _manufacturer, _name, out _);
                bool value = EquipmentInventory.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void DeleteByFullNameTest()
        {
            bool bAns = false;
            try
            {
                AddTestEquipmentExists();
                bool value = EquipmentInventory.Delete(_databasePath, _manufacturer, _name, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                long value = EquipmentInventory.GetId(_databasePath, _existingManu, _existingName, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void GetNameTest()
        {
            bool bAns = false;
            try
            {
                string value = EquipmentInventory.GetName(_databasePath,_existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"VALUE RETURNED {value}, expected {_existingId}");
                bAns = (value.Equals(_existingName));
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                List<EquipmentLists> value = EquipmentInventory.GetDetails(_databasePath, _existingManu, _existingName, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.EquipmentListsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void GetDetailsIdTest()
        {
            bool bAns = false;
            try
            {
                List<EquipmentLists> value = EquipmentInventory.GetDetails(_databasePath, _existingId, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.EquipmentListsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = EquipmentInventory.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Inventory Listings - Equipment")]
        public void DataExistsByManuNameTest()
        {
            bool bAns = false;
            try
            {
                bool value = EquipmentInventory.DataExists(_databasePath, _existingManu, _existingName, out _errOut);
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
