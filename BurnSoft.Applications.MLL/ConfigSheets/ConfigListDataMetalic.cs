using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;


namespace BurnSoft.Applications.MLL.ConfigSheets
{
    /// <summary>
    /// Class ConfigListDataMetalic helps manahe the data on 
    /// the Config_List_Data_NSG table
    /// </summary>
    public class ConfigListDataMetalic
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.ConfigSheets.ConfigListDataMetalic";

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
        /// <returns>List&lt;ConfigListDataMetalicData&gt;.</returns>
        private static List<ConfigListDataMetalicData> GetData(DataTable dt, out string errOut)
        {
            List<ConfigListDataMetalicData> lst = new List<ConfigListDataMetalicData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new ConfigListDataMetalicData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        ConfgNameId = Convert.ToInt32(d["CLNID"]),
                        AmmoTypeId = Convert.ToInt32(d["ATID"]),
                        CaliberId = Convert.ToInt32(d["CALID"]),
                        BulletId = Convert.ToInt32(d["BID"]),
                        PrimerId = Convert.ToInt32(d["PRID"]),
                        CaseId = Convert.ToInt32(d["CAID"]),
                        Source = d["Source"] != DBNull.Value ? d["Source"].ToString().Trim() : "",
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
        /// <returns>List&lt;ConfigListDataMetalicData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<ConfigListDataMetalicData> GetList(string databasePath, string sql, out string errOut)
        {
            List<ConfigListDataMetalicData> lst = new List<ConfigListDataMetalicData>();
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
        /// <returns>List&lt;ConfigListDataMetalicData&gt;.</returns>
        public static List<ConfigListDataMetalicData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from Config_List_Data_NSG order by CLNID  ASC";
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
                string sql = $"Select * from Config_List_Data_NSG where CLNID={ConfigNameId}";
                List<ConfigListDataMetalicData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (ConfigListDataMetalicData i in lst)
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
        /// <returns>List&lt;ConfigListDataMetalicData&gt;.</returns>
        public static List<ConfigListDataMetalicData> GetDetails(string databasePath, int id, out string errOut)
        {
            string sql = $"Select * from Config_List_Data_NSG where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="Configid">The configid.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ConfigListDataMetalicData&gt;.</returns>
        public static List<ConfigListDataMetalicData> GetDetails(string databasePath, long Configid, out string errOut)
        {
            string sql = $"Select * from Config_List_Data_NSG where CLNID={Configid}";
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
                List<ConfigListDataMetalicData> lst = GetAll(databasePath, out errOut);
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

                List<ConfigListDataMetalicData> lst = GetDetails(databasePath, Configid, out errOut);
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
        /// <param name="BulletId">The bullet identifier.</param>
        /// <param name="PrimerId">The primer identifier.</param>
        /// <param name="CaseId">The case identifier.</param>
        /// <param name="source">The source.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, int ConfgNameId, int AmmoTypeId, int CaliberId, 
            int BulletId, int PrimerId, int CaseId, string source,  out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"INSERT INTO Config_List_Data_NSG(CLNID,ATID,CALID," +
                    $"BID,PRID,CAID,Source) VALUES(" +
                    $"{ConfgNameId}, {AmmoTypeId}, {CaliberId}, " +
                    $"{BulletId}, {PrimerId}, {CaseId}, '{o.FC(source)}')";

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
        /// <param name="AmmoTypeId">The ammo type identifier.</param>
        /// <param name="CaliberId">The caliber identifier.</param>
        /// <param name="BulletId">The bullet identifier.</param>
        /// <param name="PrimerId">The primer identifier.</param>
        /// <param name="CaseId">The case identifier.</param>
        /// <param name="source">The source.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, int ConfgNameId, int AmmoTypeId, int CaliberId,
            int BulletId, int PrimerId, int CaseId, string source, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {

                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE Config_List_Data_NSG set CLNID={ConfgNameId}," +
                    $"ATID={AmmoTypeId},CALID={CaliberId},BID={BulletId}, PRID={PrimerId}, " +
                    $"CAID={CaseId}, source='{o.FC(source)}' where id={id}";

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
                string sql = $"DELETE from Config_List_Data_NSG where id={id}";
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
