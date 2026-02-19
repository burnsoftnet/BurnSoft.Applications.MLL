using BurnSoft.Applications.MLL.Types;
using BurnSoft.Security.RegularEncryption.SHA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.Applications.MLL.LoadersLog
{
    /// <summary>
    /// Class Firearms which handles the local collection for 
    /// the loaders log firearms that is used
    /// </summary>
    public class Firearms
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.LoadersLog.Firearms";

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

        private static List<FirearmCollection> GetData(DataTable dt, out string errOut)
        {
            List<FirearmCollection> lst = new List<FirearmCollection>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new FirearmCollection()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        MyGunCollectionId = Convert.ToInt32(d["MGCID"]),
                        FullName = d["FullName"] != DBNull.Value ? d["FullName"].ToString().Trim() : "",
                        Manufacturer = d["Manu"] != DBNull.Value ? d["Manu"].ToString().Trim() : "",
                        Model = d["Model"] != DBNull.Value ? d["Model"].ToString().Trim() : "",
                        Caliber = d["Cal"] != DBNull.Value ? d["Cal"].ToString().Trim() : "",
                        Barrel = d["Barrel"] != DBNull.Value ? d["Barrel"].ToString().Trim() : "",
                        SerialNo = d["SerialNo"] != DBNull.Value ? d["SerialNo"].ToString().Trim() : "",
                        GunType = d["GType"] != DBNull.Value ? d["GType"].ToString().Trim() : "",
                        Exclude = Convert.ToInt32(d["Exclude"]) == 1,
                        LastSync = d["sync_lastupdate"].ToString().Trim(),
                    });
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetData", e);
            }
            return lst;
        }
    }
}
