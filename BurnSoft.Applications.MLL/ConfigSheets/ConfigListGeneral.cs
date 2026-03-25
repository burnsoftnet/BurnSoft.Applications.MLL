using System;


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
                if (errOut.Length > 0) throw new Exception(errOut);
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
        /// <param name="Id">The projectile identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if [is slug configuration] [the specified database path]; otherwise, <c>false</c>.</returns>
        public static bool IsSlugConfig(string databasePath, long Id, out string errOut)
        {
            bool bAns = false;
            try
            {
                string sql = $"Select IsSlug from List_SG_ShotType_Details where ID={Id}";
                int value = Database.GetGetNumericValue(databasePath, "IsSlug", sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = (value == 1);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("IsSlugConfig", e);
            }
            return bAns;
        }
        /// <summary>
        /// Ins the shotgun configs
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="ammoTypeId">The ammunition type identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool InShotgun(string databasePath, long ammoTypeId, out string errOut)
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
                    $"Config_List_Data_SG.ATID={ammoTypeId} order by Config_List_Name.ConfigName ASC";
                bAns = Database.DataExists(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("InShotgun", e);
            }
            return bAns;
        }
        /// <summary>
        /// In the metallic config.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="caliberId">The caliber identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool InMetallic(string databasePath, long caliberId, out string errOut)
        {
            bool bAns = false;
            try
            {
                string sql = $"SELECT Config_List_Name.ID,Config_List_Name.ConfigName,Config_List_Name.IsPersonal," +
                    $"Config_List_Name.IsActive,Config_List_Name.IsFav,Config_List_Name.IsShotgun, Config_List_Data_NSG.ATID, " +
                    $"Config_List_Data_NSG.CALID,Config_List_Data_NSG.CAID, Config_List_Data_NSG.BID, " +
                    $"Config_List_Data_NSG.PRID from Config_List_Name INNER JOIN Config_List_Data_NSG on " +
                    $"Config_List_Data_NSG.CLNID=Config_List_Name.ID  where Config_List_Data_NSG.CALID={caliberId} order by Config_List_Name.ConfigName ASC";
                bAns = Database.DataExists(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("InMetallic", e);
            }
            return bAns;
        }
        /// <summary>
        /// Determines whether [is not in shotgun configuration by caliber] [the specified database path].
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="caliberId">The caliber identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if [is not in shotgun configuration by caliber] [the specified database path]; otherwise, <c>false</c>.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool IsNotInShotgunConfigByCaliber(string databasePath, long caliberId, out string errOut)
        {
            bool bAns = false;
            try
            {
                if (!InMetallic(databasePath, caliberId, out errOut))
                {
                    if (errOut.Length > 0) throw new Exception(errOut);
                    if (!InShotgun(databasePath, caliberId, out errOut))
                    {
                        if (errOut.Length > 0) throw new Exception(errOut);
                        bAns = false ;
                    }
                    else
                    {
                        bAns = true;
                    }
                } else
                {
                    bAns = true;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("IsNotInShotgunConfigByCaliber", e);
            }
            return bAns;
        }
    }
}
