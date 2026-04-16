using BurnSoft.Applications.MLL.Helpers;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.ConfigSheets
{
    /// <summary>
    /// Class ConfigListDataShotgun to handle the data 
    /// in the Config_List_Data_SG table
    /// </summary>
    public class ConfigListDataShotgun
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.ConfigSheets.ConfigListDataShotgun";

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
        /// <returns>List&lt;ConfigListDataShotgunData&gt;.</returns>
        private static List<ConfigListDataShotgunData> GetData(DataTable dt, out string errOut)
        {
            List<ConfigListDataShotgunData> lst = new List<ConfigListDataShotgunData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new ConfigListDataShotgunData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        ConfgNameId = Convert.ToInt32(d["CLNID"]),
                        AmmoTypeId = Convert.ToInt32(d["ATID"]),
                        CaliberId = Convert.ToInt32(d["CALID"]),
                        PrimerId = Convert.ToInt32(d["PRID"]),
                        CaseId = Convert.ToInt32(d["CAID"]),
                        Source = d["Source"] != DBNull.Value ? d["Source"].ToString().Trim() : "",
                        ShotWeight = Convert.ToDouble(d["SW"]),
                        ShotWeightText = d["SW_t"] != DBNull.Value ? d["SW_t"].ToString().Trim() : "",
                        ShotSize = Convert.ToInt32(d["SS"]),
                        Bushing = Convert.ToInt32(d["Bushing"]),
                        Wad = Convert.ToInt32(d["Wad"]),
                        ShotChargeLoad = Convert.ToInt32(d["SCL"]),
                        GunId = Convert.ToInt32(d["gid"]),
                        IsPersonal = Convert.ToInt32(d["IsPersonal"]) == 1 ? true : false,
                        ListTypeId = Convert.ToInt32(d["LTID"]),
                        BushingId = d["BushingId"] != DBNull.Value ? Convert.ToInt32(d["BushingId"]) : 0,
                        ChargeBarId = d["ChargeBarId"] != DBNull.Value ?  Convert.ToInt32(d["ChargeBarId"]) : 0,
                        LastSync = d["sync_lastupdate"] != DBNull.Value ? d["sync_lastupdate"].ToString().Trim() : DateTime.Now.ToString()
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
        /// <returns>List&lt;ConfigListDataShotgunData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<ConfigListDataShotgunData> GetList(string databasePath, string sql, out string errOut)
        {
            List<ConfigListDataShotgunData> lst = new List<ConfigListDataShotgunData>();
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
                errOut = $"{errOut}{Environment.NewLine}SQL: {sql}";
            }
            return lst;
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListDataShotgunData&gt;.</returns>
        public static List<ConfigListDataShotgunData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from Config_List_Data_SG order by CLNID  ASC";
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
                string sql = $"Select * from Config_List_Data_SG where CLNID={ConfigNameId}";
                List<ConfigListDataShotgunData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (ConfigListDataShotgunData i in lst)
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
        /// <returns>List&lt;ConfigListDataShotgunData&gt;.</returns>
        public static List<ConfigListDataShotgunData> GetDetails(string databasePath, int id, out string errOut)
        {
            string sql = $"Select * from Config_List_Data_SG where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="Configid">The configid.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListDataShotgunData&gt;.</returns>
        public static List<ConfigListDataShotgunData> GetDetails(string databasePath, long Configid, out string errOut)
        {
            string sql = $"Select * from Config_List_Data_SG where CLNID={Configid}";
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
                List<ConfigListDataShotgunData> lst = GetAll(databasePath, out errOut);
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

                List<ConfigListDataShotgunData> lst = GetDetails(databasePath, Configid, out errOut);
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
        /// <param name="AmmoTypeId">The ammo type identifier.</param>
        /// <param name="CaliberId">The caliber identifier.</param>
        /// <param name="PrimerId">The primer identifier.</param>
        /// <param name="CaseId">The case identifier.</param>
        /// <param name="shotWeight">The shot weight.</param>
        /// <param name="shotWeightText">The shot weight text.</param>
        /// <param name="shotSize">Size of the shot.</param>
        /// <param name="bushing">The bushing.</param>
        /// <param name="wad">The wad.</param>
        /// <param name="shotChargeLoad">The shot charge load.</param>
        /// <param name="source">The source.</param>
        /// <param name="gunId">The gun identifier.</param>
        /// <param name="isPersonal">if set to <c>true</c> [is personal].</param>
        /// <param name="listTypeId">The list type identifier.</param>
        /// <param name="bushingId">The bushing identifier.</param>
        /// <param name="chargeBarId">The charge bar identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, int ConfgNameId, int AmmoTypeId, int CaliberId,
            int PrimerId, int CaseId, double shotWeight, string shotWeightText, long shotSize, 
            long bushing, long wad, long shotChargeLoad, string source, long gunId, bool isPersonal, 
            long listTypeId, long bushingId, long chargeBarId, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int iPersonal = isPersonal ? 0 : 1;
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"INSERT INTO Config_List_Data_SG(CLNID,ATID,CALID," +
                    $"PRID,CAID,SW, SW_t, ss, Bushing, wad, SCL, Source, gid, " +
                    $"ispersonal, LTID, BushingId, ChargeBarId) VALUES(" +
                    $"{ConfgNameId}, {AmmoTypeId}, {CaliberId}, " +
                    $"{PrimerId}, {CaseId}, {shotWeight}, '{shotWeightText}', " +
                    $"{shotSize}, {bushing}, {wad},{shotChargeLoad},'{o.FC(source)}', " +
                    $"{gunId}, {iPersonal}, {listTypeId}, {bushingId}, {chargeBarId})";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }
            return bAns;
        }
        /// <summary>
        /// Copies the configuration settings from an existing to a new config.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="newConfigId">The new configuration identifier.</param>
        /// <param name="oldConfigId">The old configuration identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool CopyConfig(string databasePath, int newConfigId, long oldConfigId, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                List<ConfigListDataShotgunData> lst = GetDetails(databasePath, oldConfigId, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (ConfigListDataShotgunData d in lst)
                {
                    if (!Add(databasePath, newConfigId, d.AmmoTypeId, d.CaliberId, d.PrimerId, d.CaseId, 
                        d.ShotWeight, d.ShotWeightText, d.ShotSize, d.Bushing, d.Wad, d.ShotChargeLoad, 
                        GeneralHelpers.FluffContent(d.Source), d.GunId, d.IsPersonal, d.ListTypeId, 
                        d.BushingId, d.ChargeBarId, out errOut)) throw new Exception(errOut);
                }
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("CopyConfig", e);
            }
            return bAns;
        }

        /// <summary>
        /// Updates the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="ConfgNameId">The confg name identifier.</param>
        /// <param name="AmmoTypeId">The ammo type identifier.</param>
        /// <param name="CaliberId">The caliber identifier.</param>
        /// <param name="PrimerId">The primer identifier.</param>
        /// <param name="CaseId">The case identifier.</param>
        /// <param name="shotWeight">The shot weight.</param>
        /// <param name="shotWeightText">The shot weight text.</param>
        /// <param name="shotSize">Size of the shot.</param>
        /// <param name="bushing">The bushing.</param>
        /// <param name="wad">The wad.</param>
        /// <param name="shotChargeLoad">The shot charge load.</param>
        /// <param name="source">The source.</param>
        /// <param name="gunId">The gun identifier.</param>
        /// <param name="isPersonal">if set to <c>true</c> [is personal].</param>
        /// <param name="listTypeId">The list type identifier.</param>
        /// <param name="bushingId">The bushing identifier.</param>
        /// <param name="chargeBarId">The charge bar identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, int ConfgNameId, int AmmoTypeId, int CaliberId,
            int PrimerId, int CaseId, double shotWeight, string shotWeightText, long shotSize,
            long bushing, long wad, long shotChargeLoad, string source, long gunId, bool isPersonal,
            long listTypeId, long bushingId, long chargeBarId, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int iPersonal = isPersonal ? 0 : 1;
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE Config_List_Data_SG set CLNID={ConfgNameId}," +
                    $"ATID={AmmoTypeId},CALID={CaliberId}, PRID={PrimerId}, " +
                    $"CAID={CaseId}, source='{o.FC(source)}', SW={shotWeight}, ss={shotSize}," +
                    $"SW_t='{shotWeightText}', Bushing={bushing}, wad={wad}, " +
                    $"SCL={shotChargeLoad},gid={gunId}, ispersonal={iPersonal}, " +
                    $"LTID={listTypeId}, BushingId={bushingId}, ChargeBarId={chargeBarId} where id={id}";

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
                string sql = $"DELETE from Config_List_Data_SG where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }
            return bAns;
        }

        /// <summary>
        /// Deletes the by configuration identifier which will delete all the powder using the config id.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool DeleteByConfigId(string databasePath, long id, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"DELETE from Config_List_Data_SG where CLNID={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DeleteByConfigId", e);
            }
            return bAns;
        }
    }
}
