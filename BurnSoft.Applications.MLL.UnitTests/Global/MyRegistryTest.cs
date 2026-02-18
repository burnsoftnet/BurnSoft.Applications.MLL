using BurnSoft.Applications.MLL.Global;
using BurnSoft.Applications.MLL.PeopleAndPlaces;
using BurnSoft.Applications.MLL.Types;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.Global
{
    [TestClass]
    public class MyRegistryTest
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
        private string _viewSettings;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _viewSettings = "View_Bullets";
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void GetSettingsTest()
        {
            bool bAns = false;
            try
            {
                List<RegistrySettings> value = MyRegistry.GetSettings(out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.RegistrySettingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void MyGunCollectionIsInstalledTest()
        {
            bool bAns = false;
            try
            {
                bool value = MyRegistry.MyGunCollectionIsInstalled(out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"Gun Collection Installed: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void GetExePathTest()
        {
            bool bAns = false;
            try
            {
                string value = MyRegistry.GetExePath(out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"EXE Path: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void GetDatabaseLocationTest()
        {
            bool bAns = false;
            try
            {
                string value = MyRegistry.GetDatabaseLocation(out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"EXE Path: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void GetViewSettingsTest()
        {
            bool bAns = false;
            try
            {
                string value = MyRegistry.GetViewSettings(_viewSettings, out _errOut, sDefault: "All");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"View Settings Value: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void SaveViewSettingsTest()
        {
            bool bAns = false;
            try
            {
                TestContext.WriteLine($"VIEW SETTINGS BEFORE FOR {_viewSettings}: {MyRegistry.GetViewSettings(_viewSettings, out _errOut, sDefault: "All")}");
                bool value = MyRegistry.SaveViewSettings(_viewSettings, "In Stock", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"View Settings Value: {value}");
                TestContext.WriteLine($"VIEW SETTINGS AFTER FOR {_viewSettings}: {MyRegistry.GetViewSettings(_viewSettings, out _errOut, sDefault: "All")}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void GetLastWorkingDirTest()
        {
            bool bAns = false;
            try
            {
                string value = MyRegistry.GetLastWorkingDir(out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"Last Working Directory: {value}");
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        public void PrintSettings()
        {
            List<RegistrySettings> value = MyRegistry.GetSettings(out _errOut);
            if (_errOut.Length > 0) throw new Exception(_errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.RegistrySettingsData(value));
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void SaveConfigSortTest()
        {
            bool bAns = false;
            try
            {
                TestContext.WriteLine("SETTINGS BEFORE");
                TestContext.WriteLine("");
                PrintSettings();
                TestContext.WriteLine("");
                bool value = MyRegistry.SaveConfigSort("All Favorites", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine($"SAVED? : {value}");
                TestContext.WriteLine("");
                TestContext.WriteLine("SETTINGS AFTER");
                TestContext.WriteLine("");
                PrintSettings();
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void BuildRegistryDefaultsTest()
        {
            bool bAns = false;
            try
            {
                List<RegistrySettings> value = MyRegistry.BuildRegistry();
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.RegistrySettingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void BuildRegistryModifiedTest()
        {
            bool bAns = false;
            try
            {
                List<RegistrySettings> value = MyRegistry.BuildRegistry(Successful: DateTime.Now.ToString(), 
                    AlertOnBackUp: true, BackupOnExit: true, DefaultList: "All", ConfigSort: "All Favorites");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.RegistrySettingsData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Registry Functions")]
        public void SaveSettingsTest()
        {
            bool bAns = false;
            try
            {
                TestContext.WriteLine("SETTINGS BEFORE");
                TestContext.WriteLine("");
                PrintSettings();
                TestContext.WriteLine("");
                List<RegistrySettings> value = MyRegistry.BuildRegistry(Successful: DateTime.Now.ToString(),
                    AlertOnBackUp: true, BackupOnExit: true, DefaultList: "All", ConfigSort: "All");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                if (!MyRegistry.SaveSettings(value, out _errOut)) throw new Exception(_errOut);
                TestContext.WriteLine("");
                TestContext.WriteLine("SETTINGS AFTER");
                TestContext.WriteLine("");
                PrintSettings();
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
