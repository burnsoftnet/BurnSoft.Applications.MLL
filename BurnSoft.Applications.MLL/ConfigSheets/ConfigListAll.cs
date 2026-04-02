using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;


namespace BurnSoft.Applications.MLL.ConfigSheets
{
    /// <summary>
    /// Class ConfigListAll will get all the data related to the config 
    /// sheets and put them in a single list container
    /// </summary>
    public class ConfigListAll
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string _classLocation = "BurnSoft.Applications.MLL.ConfigSheets.ConfigListAll";
        /// <summary>
        /// Errors the message for regular Exceptions
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, Exception e) => $"{_classLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for access violations
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, AccessViolationException e) => $"{_classLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for invalid cast exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, InvalidCastException e) => $"{_classLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message argument exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentException e) => $"{_classLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for argument null exception.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentNullException e) => $"{_classLocation}.{functionName} - {e.Message}";
        #endregion                 
        /// <summary>
        /// Metallics the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListAllMetallicData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        public static List<ConfigListAllMetallicData> Metallic(string databasePath, long configId, out string errOut)
        {
            List<ConfigListAllMetallicData> lst = new List<ConfigListAllMetallicData>();
            errOut = "";
            try
            {
                List<ConfigNameList> configList = ConfigListDataName.GetDetails(databasePath, configId, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                List<ConfigListDataMetalicData> data = ConfigListDataMetalic.GetDetails(databasePath, configId, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                List<ConfigListPowderData> powderList = ConfigListDataPowder.GetDetails(databasePath, configId, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                lst.Add(new ConfigListAllMetallicData { 
                    ConfigSection = configList,
                    SettingsDetails = data,
                    PowderDetails = powderList,
                });
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Metallic", e);
            }
            return lst;
        }
        /// <summary>
        /// Shotguns the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListAllShotgunData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        public static List<ConfigListAllShotgunData> Shotgun(string databasePath, long configId, out string errOut)
        {
            List<ConfigListAllShotgunData> lst = new List<ConfigListAllShotgunData>();
            errOut = "";
            try
            {
                List<ConfigNameList> configList = ConfigListDataName.GetDetails(databasePath, configId, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                List<ConfigListDataShotgunData> data = ConfigListDataShotgun.GetDetails(databasePath, configId, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                List<ConfigListPowderData> powderList = ConfigListDataPowder.GetDetails(databasePath, configId, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                lst.Add(new ConfigListAllShotgunData
                {
                    ConfigSection = configList,
                    SettingsDetails = data,
                    PowderDetails = powderList,
                });
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Shotgun", e);
            }
            return lst;
        }
    }
}
