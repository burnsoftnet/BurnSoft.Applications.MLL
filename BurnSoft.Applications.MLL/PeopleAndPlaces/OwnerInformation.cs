using BurnSoft.Applications.MLL.Types;
using BurnSoft.Security.RegularEncryption.SHA;
using BurnSoft.Universal;
using Microsoft.SqlServer.Server;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BurnSoft.Applications.MLL.PeopleAndPlaces
{
    /// <summary>
    /// Class OwnerInformation.
    /// </summary>
    public class OwnerInformation
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.PeopleAndPlaces.OwnerInformation";

        /// <summary>
        /// Errors the message for regular Exceptions
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, Exception e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for access violations
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, AccessViolationException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for invalid cast exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, InvalidCastException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message argument exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for argument null exception.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentNullException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        #endregion        

        /// <summary>
        /// Gets the data from the database and puts it into a list
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;OwnerInfo&gt;.</returns>
        private static List<PersonalInformation> GetList(DataTable dt, out string errOut)
        {
            List<PersonalInformation> lst = new List<PersonalInformation>();
            errOut = @"";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new PersonalInformation()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Password = d["Password"] != DBNull.Value ? One.Decrypt(d["Password"].ToString().Trim()) : "",
                        Name = d["Name"] != DBNull.Value ? d["Name"].ToString().Trim() : "",
                        LoadName = d["Load_Name"] != DBNull.Value ? d["Load_Name"].ToString().Trim() : "",
                        Address = d["Address"] != DBNull.Value ? d["Address"].ToString().Trim() : "",
                        City = d["City"] != DBNull.Value ? d["City"].ToString().Trim() : "",
                        State = d["State"] != DBNull.Value ? d["State"].ToString().Trim() : "",
                        ZipCode = d["ZipCode"] != DBNull.Value ? d["ZipCode"].ToString().Trim() : "",
                        Phone = d["Phone"] != DBNull.Value ? d["Phone"].ToString().Trim() : "",
                        License = d["lic"] != DBNull.Value ? d["lic"].ToString().Trim() : "",
                        UseLock = Convert.ToInt32(d["UseLock"]) == 1,
                        UserName = d["UserName"] != DBNull.Value ? One.Decrypt(d["UserName"].ToString().Trim()) : "",
                        Forgot = d["Password_Forgot"] != DBNull.Value ? One.Decrypt(d["Password_Forgot"].ToString().Trim()) : "",
                        ForgetPhrase = d["Password_Forgot_word"] != DBNull.Value ? One.Decrypt(d["Password_Forgot_word"].ToString().Trim()) : "",
                        LastSync = d["sync_lastupdate"].ToString().Trim(),
                    });
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetList", e);
            }
            return lst;
        }
        /// <summary>
        /// Gets all data from the Personal Information Table
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PersonalInformation&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        public static List<PersonalInformation> GetAllData(string databasePath, out string errOut)
        {
            List<PersonalInformation> lst = new List<PersonalInformation>();
            errOut = @"";
            try
            {
                string sql = "SELECT * from Personal_Information order by ID ASC";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                lst = GetList(dt, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetAllData", e);
            }
            return lst;
        }
        /// <summary>
        /// Gets the data from yhr Personal Information Table for the Top User listed
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PersonalInformation&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        public static List<PersonalInformation> GetData(string databasePath, out string errOut)
        {
            List<PersonalInformation> lst = new List<PersonalInformation>();
            errOut = @"";
            try
            {
                string sql = "SELECT TOP 1 * from Personal_Information";
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                lst = GetList(dt, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetData", e);
            }
            return lst;
        }

        /// <summary>
        /// Gets the name of the load.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        public static string GetLoadName(string databasePath, out string errOut)
        {
            string sAns = "";
            errOut = "";
            try
            {
                List<PersonalInformation> lst = GetData(databasePath, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach(PersonalInformation item in lst)
                {
                    sAns = item.LoadName;
                    break;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetLoadName", e);
            }

            return sAns;
        }

        /// <summary>
        /// Get the information related only to the login information, There is default information listed
        /// just in case someone click on the lock option but doesn't set the other information and close the application
        /// if this happens then they will not be able to log in.  The default will help save them in this
        /// where it will give a backup default if that information is not set.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoginInformationOnly&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        public static List<LoginInformationOnly> LoginEnabled(string databasePath, out string errOut)
        {
            List<LoginInformationOnly> lst = new List<LoginInformationOnly>();
            errOut = "";
            try
            {
                bool hasData = DataExists(databasePath, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                string defaultUser = "admin";
                string defaultPwd = "admin";
                string defaultForgot = "burnsoft";
                string defaultForgotPhrase = "The Company that made this App";
                if (hasData)
                {
                    List<PersonalInformation> data = GetData(databasePath, out errOut);
                    if (errOut.Length > 0) throw new Exception(errOut);
                    foreach (PersonalInformation p in data)
                    {
                        if (p.UseLock)
                        {
                            string pwd = p.Password.Length > 0 ? p.Password : defaultPwd;
                            string uid = p.UserName.Length > 0 ? p.UserName : defaultUser;
                            string forgotPhrase = p.ForgetPhrase.Length > 0 ? p.ForgetPhrase : defaultForgotPhrase;
                            string forgot = p.Forgot.Length > 0 ? p.Forgot : defaultForgot;

                            lst.Add(new LoginInformationOnly
                            {
                                UseLock = p.UseLock,
                                Password = pwd,
                                UserName = uid,
                                ForgetPhrase = forgotPhrase,
                                Forgot = forgot
                            });
                        } else
                        {
                            lst.Add(new LoginInformationOnly
                            {
                                UseLock = false,
                                Password = defaultPwd,
                                UserName = defaultUser,
                                ForgetPhrase = defaultForgotPhrase,
                                Forgot = defaultForgot
                            });
                        }
                    }
                } else
                {
                    lst.Add(new LoginInformationOnly
                    {
                        UseLock = false,
                        Password = defaultPwd,
                        UserName = defaultUser,
                        ForgetPhrase = defaultForgotPhrase,
                        Forgot = defaultForgot
                    });
                }
                
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("LoginEnabled", e);
            }
            return lst;
        }

        /// <summary>
        /// Gets the maximum identifier for the owner.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int32.</returns>
        /// <exception cref="System.Exception"></exception>
        public static int GetOwnerID(string databasePath, out string errOut)
        {
            int iAns = 0;
            errOut = @"";
            try
            {
                string sql = "SELECT * from Personal_Information";
                iAns = Database.GetIDFromTableBasedOnTSQL(databasePath, sql, "id", out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetOwnerID", e);
            }
            return iAns;
        }

        /// <summary>
        /// Adds The owner Information to the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="loadName">Name of the load.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="license">The license.</param>
        /// <param name="usePassword">if set to <c>true</c> [use password].</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="forgotPhrase">The forgot phrase.</param>
        /// <param name="forgotAnswer">The forgot answer.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string name, string loadName, string address, string city, string state, string zipCode, string phone, string license, bool usePassword,
            string username, string password, string forgotPhrase, string forgotAnswer, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                int useLock = usePassword ? 1 : 0;
                string sql = "INSERT INTO Personal_Information (Name, Load_Name, Address, City, " +
                    "State, ZipCode, Phone, Lic, UseLock, UserName, Password, Password_Forgot, " +
                    $"Password_Forgot_word) VALUES('{o.FC(name)}', '{o.FC(loadName)}', '{o.FC(address)}', '{o.FC(city)}', " +
                    $"'{o.FC(state)}', '{o.FC(zipCode)}', '{o.FC(phone)}', '{o.FC(license)}', {useLock}, '{One.Encrypt(o.FC(username))}', " +
                    $"'{One.Encrypt(o.FC(password))}', '{One.Encrypt(o.FC(forgotPhrase))}', '{One.Encrypt(o.FC(forgotAnswer))}')";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="loadName">Name of the load.</param>
        /// <param name="address">The address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="phone">The phone.</param>
        /// <param name="license">The license.</param>
        /// <param name="usePassword">if set to <c>true</c> [use password].</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="forgotPhrase">The forgot phrase.</param>
        /// <param name="forgotAnswer">The forgot answer.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, int id, string name, string loadName, string address, string city, 
            string state, string zipCode, string phone, string license, bool usePassword,
            string username, string password, string forgotPhrase, string forgotAnswer, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                int useLock = usePassword ? 1 : 0;
                string sql = $"UPDATE Personal_Information set Load_Name='{o.FC(loadName)}',Name='{o.FC(name)}',Address='{o.FC(address)}'" +
                        $",City='{o.FC(city)}',State='{o.FC(state)}',ZipCode='{o.FC(zipCode)}', Phone='{o.FC(phone)}',Lic='{o.FC(license)}', " +
                        $"UseLock={useLock},UserName='{One.Encrypt(o.FC(username))}',Password='{One.Encrypt(o.FC(password))}'," +
                        $"Password_forgot='{One.Encrypt(o.FC(forgotPhrase))}',Password_Forgot_word='{One.Encrypt(o.FC(forgotAnswer))}' " +
                        $"where ID={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }
            return bAns;
        }

        /// <summary>
        /// Deletes everything from the Personal_Information table.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Delete(string databasePath, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                string sql = $"DELETE FROM Personal_Information";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }
            return bAns;
        }

        /// <summary>
        /// Deletes the row based on the id from the Personal_Information table.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Delete(string databasePath, int id, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                string sql = $"DELETE FROM Personal_Information where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }
            return bAns;
        }

        /// <summary>
        /// Datas the exists.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                List<PersonalInformation> lst = GetAllData(databasePath, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExists", e);
            }
            return bAns;
        }


    }
}
