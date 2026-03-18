using BurnSoft.Applications.MLL.Global;
using BurnSoft.Applications.MLL.Search;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Global
{
    [TestClass]
    public class WishlistsTests
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
        /// The table name
        /// </summary>
        private string _manufacturer;
        /// <summary>
        /// The model
        /// </summary>
        private string _model;
        /// <summary>
        /// The existing manufacturer
        /// </summary>
        private string _existingManufacturer;
        /// <summary>
        /// The existing model
        /// </summary>
        private string _existingModel;
        /// <summary>
        /// The existing identifier
        /// </summary>
        private int _existingId;
        private string _placeToBuy;
        public string _qty;
        public string _value;
        public string _notes;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            _manufacturer = "Config_List_Data_NSG";
            _existingId = 6;
            _existingManufacturer = "Champion";
            _existingModel = "deer x-ray target";
            _manufacturer = "LEE";
            _model = "22 TCM Carbide Dies";
            _placeToBuy = "midway usa";
            _qty = "1";
            _value = "49.99";
            _notes = "4 set dies";
        }

        [TestMethod, TestCategory("Wish Lists")]
        public void GetDetailsTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = Wishlists.GetId(_databasePath, _existingManufacturer, _existingModel, out _errOut);
                List<WishlistData> value = Wishlists.GetDetails(_databasePath, (int)id, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.WishlistDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Wish Lists")]
        public void GetAllTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<WishlistData> value = Wishlists.GetAll(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.WishlistDataData(value));
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
            if (!Wishlists.DataExists(_databasePath, _manufacturer, _model, out _))
            {
                Wishlists.Add(_databasePath, _manufacturer, _model, _placeToBuy, 
                    _qty, _value, _notes, out _);
            }
        }

        private void DeleteTestDataExists()
        {
            if (Wishlists.DataExists(_databasePath, _manufacturer, _model, out _))
            {
                long id = Wishlists.GetId(_databasePath, _manufacturer, _model, out _);
                Wishlists.Delete(_databasePath, id, out _);
            }
        }

        [TestMethod, TestCategory("Wish Lists")]
        public void GetDetailsDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                List<WishlistData> value = Wishlists.GetDetails(_databasePath, _existingManufacturer, _existingModel, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.WishlistDataData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Wish Lists")]
        public void GetIdTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long value = Wishlists.GetId(_databasePath, _existingManufacturer, _existingModel, out _errOut);
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

        [TestMethod, TestCategory("Wish Lists")]
        public void DataExistsTest()
        {
            bool bAns = false;
            try
            {
                bool value = Wishlists.DataExists(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Wish Lists")]
        public void DataExistsDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = Wishlists.DataExists(_databasePath, _existingManufacturer, _existingModel, out _errOut);
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
            List<WishlistData> value = Wishlists.GetDetails(_databasePath, _existingManufacturer, _existingModel, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.WishlistDataData(value));
            TestContext.WriteLine($"");
        }

        [TestMethod, TestCategory("Wish Lists")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                DeleteTestDataExists();
                bool value = Wishlists.Add(_databasePath, _manufacturer, _model, _placeToBuy,
                    _qty, _value, _notes, out _errOut);
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

        [TestMethod, TestCategory("Wish Lists")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                PrintTestData();
                long id = Wishlists.GetId(_databasePath, _manufacturer, _model, out _);
                bool value = Wishlists.Update(_databasePath, id, _manufacturer, _model, 
                    _placeToBuy, "2", _value + "ea.", _notes, out _errOut);
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

        [TestMethod, TestCategory("Wish Lists")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                long id = Wishlists.GetId(_databasePath, _manufacturer, _model, out _);
                bool value = Wishlists.Delete(_databasePath, id, out _errOut);
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

        [TestMethod, TestCategory("Wish Lists")]
        public void DeleteByDescriptionTest()
        {
            bool bAns = false;
            try
            {
                AddTestDataExists();
                bool value = Wishlists.Delete(_databasePath, _manufacturer, _model, out _errOut);
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
