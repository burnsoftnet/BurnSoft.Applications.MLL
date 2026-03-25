using BurnSoft.Applications.MLL.AutoFill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.Applications.MLL.ConfigSheets
{
    /// <summary>
    /// Class ConfigListGeneral contains general functions relating to different 
    /// sections of the confg sheets section
    /// </summary>
    public class ConfigListGeneral
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.ConfigSheets.ConfigListGeneral";

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
        /// Determines whether [is shotgun configuration] [the specified database path].
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="caliberId">The caliber identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if [is shotgun configuration] [the specified database path]; otherwise, <c>false</c>.</returns>
        public static bool IsShotgunConfig(string databasePath, long caliberId, out string errOut)
        {
            bool bAns = false;
            try
            {
                bAns = Database.ObjectExistsInDb(databasePath, "Id", "qry_ConfigCal_SG", caliberId, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("IsShotgunConfig", e);
            }
            return bAns;
        }
        /// <summary>
        /// Determines whether [is slug configuration] [the specified database path].
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="Id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if [is slug configuration] [the specified database path]; otherwise, <c>false</c>.</returns>
        public static bool IsSlugConfig(string databasePath, long Id, out string errOut)
        {
            bool bAns = false;
            try
            {
                bAns = Database.ObjectExistsInDb(databasePath, "Id", "qry_ConfigCal_SG", Id, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("IsSlugConfig", e);
            }
            return bAns;
        }
        /// <summary>
        /// Ins the shotgun.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="caliberId">The caliber identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool InShotgun(string databasePath, long caliberId, out string errOut)
        {
            bool bAns = false;
            try
            {
                string sql = $"SELECT Config_List_Name.ID,Config_List_Name.ConfigName,Config_List_Name.IsPersonal," +
                    $"Config_List_Name.IsActive,Config_List_Name.IsFav,Config_List_Name.IsShotgun, " +
                    $"Config_List_Data_SG.ATID,Config_List_Data_SG.CALID,Config_List_Data_SG.PRID," +
                    $"Config_List_Data_SG.CAID,Config_List_Data_SG.SW,Config_List_Data_SG.SS,Config_List_Data_SG.WAD," +
                    $"Config_List_Data_SG.SCL,Config_List_Data_SG.GID,Config_List_Data_SG.LTID from Config_List_Name " +
                    $"INNER JOIN Config_List_Data_SG on Config_List_Data_SG.CLNID=Config_List_Name.ID where " +
                    $"Config_List_Data_SG.ATID={caliberId} order by Config_List_Name.ConfigName ASC";
                bAns = Database.DataExists(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("InShotgun", e);
            }
            return bAns;
        }
    }
}
