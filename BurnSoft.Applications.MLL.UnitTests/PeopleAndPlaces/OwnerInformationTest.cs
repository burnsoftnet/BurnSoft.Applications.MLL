using BurnSoft.Applications.MLL.PeopleAndPlaces;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Applications.MLL.UnitTests.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BurnSoft.Applications.MLL.UnitTests.PeopleAndPlaces
{
    [TestClass]
    public class OwnerInformationTest
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
        /// The owner identifier
        /// </summary>
        private long OwnerId;
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            // Vs2019.GetSetting("");
            _errOut = @"";
            _databasePath = Vs2019.GetSetting("DatabasePath");
            OwnerId = Convert.ToInt32(Vs2019.GetSetting("OwnerId"));
        }
        [TestMethod, TestCategory("Personal Information")]
        public void GetAllDataTest()
        {
            bool bAns = false;
            try
            {
                List<PersonalInformation> value = OwnerInformation.GetAllData(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PersonalInformationData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        private void GetAllDataAndPrint()
        {
            List<PersonalInformation> value = OwnerInformation.GetAllData(_databasePath, out _errOut);
            TestContext.WriteLine(DebugHelpers.PrintListValues.PersonalInformationData(value));
        }

        private bool AddOwner()
        {
            return OwnerInformation.Add(_databasePath, "John Doe", "Ky Ballistics", "234 there", "Lexington",
                    "ky", "40601", "555-867-5309", "MLKY39394858", false, "johnedoe", "21232ksksdfj",
                    "forgot it", "i did", out _errOut);
        }

        [TestMethod, TestCategory("Personal Information")]
        public void AddTest()
        {
            bool bAns = false;
            try
            {
                if (OwnerInformation.DataExists(_databasePath, out _errOut))
                {
                    OwnerInformation.Delete(_databasePath, out _errOut);
                }
                bAns = AddOwner();
                if (_errOut.Length > 0) throw new Exception(_errOut);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Personal Information")]
        public void GetDataTest()
        {
            bool bAns = false;
            try
            {
                if (!OwnerInformation.DataExists(_databasePath, out _errOut))
                {
                    AddOwner();
                }
                List<PersonalInformation> value = OwnerInformation.GetData(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.PersonalInformationData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Personal Information")]
        public void GetLoadNameTest()
        {
            bool bAns = false;
            try
            {
                if (!OwnerInformation.DataExists(_databasePath, out _errOut))
                {
                    AddOwner();
                }
                string value = OwnerInformation.GetLoadName(_databasePath, out _errOut);
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

        [TestMethod, TestCategory("Personal Information")]
        public void LoginEnabledTest()
        {
            bool bAns = false;
            try
            {
                if (!OwnerInformation.DataExists(_databasePath, out _errOut))
                {
                    AddOwner();
                }
                List<LoginInformationOnly> value = OwnerInformation.LoginEnabled(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine(DebugHelpers.PrintListValues.LoginInformationOnlyData(value));
                bAns = true;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Personal Information")]
        public void UpdateTest()
        {
            bool bAns = false;
            try
            {
                if (!OwnerInformation.DataExists(_databasePath, out _errOut))
                {
                    AddOwner();
                }
                TestContext.WriteLine("BEFORE");
                GetAllDataAndPrint();
                int id = OwnerInformation.GetOwnerID(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                bAns = OwnerInformation.Update(_databasePath, id, "John Doe", "Ky Ballistics", "234 there", "Lexington",
                    "ky", "40601", "555-867-5309", "MLKY38484888", true, "johnedoe", "21232ksksdfj",
                    "forgot it", "i did", out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                TestContext.WriteLine("======================================");
                TestContext.WriteLine("AFTER");
                GetAllDataAndPrint();
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Personal Information")]
        public void GetOwnerIDTest()
        {
            bool bAns = false;
            try
            {
                if (!OwnerInformation.DataExists(_databasePath, out _errOut))
                {
                    AddOwner();
                }
                int iAns = OwnerInformation.GetOwnerID(_databasePath, out _errOut);
                TestContext.WriteLine($"VALUE: {iAns}");
                if (_errOut.Length > 0) throw new Exception(_errOut);
                bAns = iAns > 0;
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }

        [TestMethod, TestCategory("Personal Information")]
        public void DeleteTest()
        {
            bool bAns = false;
            try
            {
                if (!OwnerInformation.DataExists(_databasePath, out _errOut))
                {
                    AddOwner();
                }
                int id = OwnerInformation.GetOwnerID(_databasePath, out _errOut);
                if (_errOut.Length > 0) throw new Exception(_errOut);
                bAns = OwnerInformation.Delete(_databasePath, id, out _errOut);
                if (bAns)
                {
                    TestContext.WriteLine($"Was able to delete owner with id of {id} ");
                }
                else
                {
                    TestContext.WriteLine($"Was NOT able to delete owner with id of {id} ");
                }
                if (_errOut.Length > 0) throw new Exception(_errOut);
            }
            catch (Exception ex)
            {
                TestContext.WriteLine(ex.Message);
            }
            General.HasTrueValue(bAns, _errOut);
        }
    }
}
