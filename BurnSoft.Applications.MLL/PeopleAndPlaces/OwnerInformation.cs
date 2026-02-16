using BurnSoft.Applications.MLL.Types;
using BurnSoft.Security.RegularEncryption.SHA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string pwd = d["pwd"].ToString().Trim();
                    string uid = d["uid"].ToString().Trim();
                    lst.Add(new PersonalInformation()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Password = d["pwd"] != DBNull.Value ? One.Decrypt(d["pwd"].ToString().Trim()) : "",
                        Name = d["Name"] != DBNull.Value ? d["Name"].ToString().Trim() : "",
                        Address = d["Address"] != DBNull.Value ? One.Decrypt(d["Address"].ToString().Trim()) : "",
                        City = d["City"] != DBNull.Value ? d["City"].ToString().Trim() : "",
                        State = d["State"] != DBNull.Value ? d["State"].ToString().Trim() : "",
                        ZipCode = d["Zip"] != DBNull.Value ? d["Zip"].ToString().Trim() : "",
                        Phone = d["Phone"] != DBNull.Value ? d["Phone"].ToString().Trim() : "",
                        License = d["lic"] != DBNull.Value ? One.Decrypt(d["lic"].ToString().Trim()) : "",
                        UseLock = Convert.ToInt32(d["UsePWD"]) == 1,
                        UserName = d["uid"] != DBNull.Value ? One.Decrypt(d["uid"].ToString().Trim()) : "",
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
    }
}
