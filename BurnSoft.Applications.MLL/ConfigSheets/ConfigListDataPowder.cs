using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.ConfigSheets
{
    /// <summary>
    /// Class ConfigListDataPowder to work with the Config_List_Powder_Data_NSG ( Metalic ) 
    /// table for shotgun see ConfigListDataPowderShotGun
    /// </summary>
    public class ConfigListDataPowder
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.ConfigSheets.ConfigListDataPowder";

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
        /// Gets the data.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListPowderData&gt;.</returns>
        private static List<ConfigListPowderData> GetData(DataTable dt, out string errOut)
        {
            List<ConfigListPowderData> lst = new List<ConfigListPowderData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new ConfigListPowderData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        ConfigId = Convert.ToInt32(d["CLNID"]),
                        PowderId = Convert.ToInt32(d["PID"]),
                        LoadMin = Convert.ToDouble(d["Load_Min"]),
                        LoadMid = Convert.ToDouble(d["Load_Mid"]),
                        LoadMax = Convert.ToDouble(d["Load_Max"]),
                        FpsMin = Convert.ToDouble(d["FPS_Min"]),
                        FpsMid = Convert.ToDouble(d["FPS_Mid"]),
                        FpsMax = Convert.ToDouble(d["FPS_Max"]),
                        CupsMin = Convert.ToDouble(d["CUPS_Min"]),
                        CupsMid = Convert.ToDouble(d["CUPS_Mid"]),
                        CupsMax = Convert.ToDouble(d["CUPS_Max"]),
                        IsDefault = Convert.ToInt32(d["IsPref"]) == 1 ? true : false,
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
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListPowderData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<ConfigListPowderData> GetList(string databasePath, string sql, out string errOut)
        {
            List<ConfigListPowderData> lst = new List<ConfigListPowderData>();
            errOut = "";
            try
            {
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                lst = GetData(dt, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetList", e);
            }
            return lst;
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListPowderData&gt;.</returns>
        public static List<ConfigListPowderData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from Config_List_Powder_Data_NSG order by CLNID ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="ConfigNameId">The configuration name identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, int ConfigNameId, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from Config_List_Powder_Data_NSG where CLNID={ConfigNameId}";
                List<ConfigListPowderData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (ConfigListPowderData i in lst)
                {
                    lAns = i.Id;
                    break;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetId", e);
            }
            return lAns;
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListPowderData&gt;.</returns>
        public static List<ConfigListPowderData> GetDetails(string databasePath, int id, out string errOut)
        {
            string sql = $"Select * from Config_List_Powder_Data_NSG where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the default powder.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="powderLoad">The powder load.</param>
        /// <param name="fps">The FPS.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetDefaultPowderId(string databasePath, int configId, out double powderLoad, out double? fps, out string errOut)
        {
            long lAns = 0;
            errOut = "";
            powderLoad = 0;
            fps = 0;
            try
            {
                string sql = $"SELECT * from Config_List_Powder_Data_NSG where IsPref=1 and CLNID={configId}";
                List<ConfigListPowderData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (ConfigListPowderData l in lst)
                {
                    lAns = l.Id;
                    powderLoad = l.LoadMid;
                    fps = l.FpsMid;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetDefaultPowder", e);
            }
            return lAns;
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="Configid">The configid.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListPowderData&gt;.</returns>
        public static List<ConfigListPowderData> GetDetails(string databasePath, long Configid, out string errOut)
        {
            string sql = $"Select * from Config_List_Powder_Data_NSG where CLNID={Configid}";
            return GetList(databasePath, sql, out errOut);
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
                List<ConfigListPowderData> lst = GetAll(databasePath, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExists", e);
            }
            return bAns;
        }
        /// <summary>
        /// Datas the exists.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="Configid">The configid.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, long Configid, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<ConfigListPowderData> lst = GetDetails(databasePath, Configid, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExists", e);
            }
            return bAns;
        }
        /// <summary>
        /// Adds the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="ConfgNameId">The confg name identifier.</param>
        /// <param name="PowderId">The powder identifier.</param>
        /// <param name="LoadMin">The load minimum.</param>
        /// <param name="LoadMid">The load mid.</param>
        /// <param name="LoadMax">The load maximum.</param>
        /// <param name="FpsMin">The FPS minimum.</param>
        /// <param name="FpsMid">The FPS mid.</param>
        /// <param name="FpsMax">The FPS maximum.</param>
        /// <param name="CupsMin">The cups minimum.</param>
        /// <param name="CupsMid">The cups mid.</param>
        /// <param name="CupsMax">The cups maximum.</param>
        /// <param name="isDefault">if set to <c>true</c> [is default].</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, long ConfgNameId, long PowderId, double LoadMin,
            double LoadMid, double LoadMax, double FpsMin, double FpsMid, double FpsMax, double CupsMin, double CupsMid, double CupsMax,
            bool isDefault, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                int IsPref = isDefault ? 0 : 1;
                string sql = $"INSERT INTO Config_List_Powder_Data_NSG(CLNID,PID,Load_Min," +
                    $"Load_Mid,Load_Max,FPS_Min,FPS_Mid,FPS_Max,CUPS_Min,CUPS_Mid,CUPS_Max,IsPref) VALUES(" +
                    $"{ConfgNameId}, {PowderId}, {LoadMin}, " +
                    $"{LoadMid}, {LoadMax}, {FpsMin}, {FpsMid}, {FpsMax}, {CupsMin}, {CupsMid}, {CupsMax}, {IsPref})";

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
        /// <param name="ConfgNameId">The confg name identifier.</param>
        /// <param name="PowderId">The powder identifier.</param>
        /// <param name="LoadMin">The load minimum.</param>
        /// <param name="LoadMid">The load mid.</param>
        /// <param name="LoadMax">The load maximum.</param>
        /// <param name="FpsMin">The FPS minimum.</param>
        /// <param name="FpsMid">The FPS mid.</param>
        /// <param name="FpsMax">The FPS maximum.</param>
        /// <param name="CupsMin">The cups minimum.</param>
        /// <param name="CupsMid">The cups mid.</param>
        /// <param name="CupsMax">The cups maximum.</param>
        /// <param name="isDefault">if set to <c>true</c> [is default].</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, long ConfgNameId, long PowderId, double LoadMin,
            double LoadMid, double LoadMax, double FpsMin, double FpsMid, double FpsMax, double CupsMin, double CupsMid, double CupsMax,
            bool isDefault, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {

                BSOtherObjects o = new BSOtherObjects();
                int IsPref = isDefault ? 0 : 1;
                string sql = $"UPDATE Config_List_Powder_Data_NSG set CLNID={ConfgNameId}," +
                    $"PID={PowderId},Load_Min={LoadMin},Load_Mid={LoadMid}, Load_Max={LoadMax}, " +
                    $"FPS_Min={FpsMin}, FPS_Mid={FpsMid}, FPS_Max={FpsMax},CUPS_Min={CupsMin},CUPS_Mid={CupsMid}, " +
                    $"CUPS_Max={CupsMax},IsPref={IsPref} where id={id}";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }
            return bAns;
        }
        /// <summary>
        /// Deletes the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Delete(string databasePath, long id, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"DELETE from Config_List_Powder_Data_NSG where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }
            return bAns;
        }
    }
}
