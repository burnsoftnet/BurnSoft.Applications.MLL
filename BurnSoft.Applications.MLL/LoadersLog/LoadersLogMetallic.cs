using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.LoadersLog
{
    /// <summary>
    /// Class LoadersLogMetallic handles the data in the Loaders_Log_NSG table.
    /// </summary>
    public class LoadersLogMetallic
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.LoadersLog.LoadersLogMetallic";

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
        /// <returns>List&lt;LoadersLogMetallicData&gt;.</returns>
        private static List<LoadersLogMetallicData> GetData(DataTable dt, out string errOut)
        {
            List<LoadersLogMetallicData> lst = new List<LoadersLogMetallicData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new LoadersLogMetallicData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        FirearmId = Convert.ToInt32(d["fid"]),
                        DateCreated = d["dt"] != DBNull.Value ? Convert.ToDateTime(d["dt"].ToString().Trim()) : DateTime.Now,
                        Yards = Convert.ToInt32(d["yds"]),
                        GroupSize = d["gs"] != DBNull.Value ? d["gs"].ToString().Trim() : "",
                        NumberOfShots = Convert.ToInt32(d["ns"]),
                        PowderDetails = d["pwm"] != DBNull.Value ? d["pwm"].ToString().Trim() : "",
                        BulletDetails = d["bullet"] != DBNull.Value ? d["bullet"].ToString().Trim() : "",
                        PrimerDetails = d["primer"] != DBNull.Value ? d["primer"].ToString().Trim() : "",
                        CaseDetails = d["case"] != DBNull.Value ? d["case"].ToString().Trim() : "",
                        TotalLenght = d["tl"] != DBNull.Value ? d["tl"].ToString().Trim() : "",
                        Conditions = d["Conditions"] != DBNull.Value ? d["Conditions"].ToString().Trim() : "",
                        Caliber = d["Caliber"] != DBNull.Value ? d["Caliber"].ToString().Trim() : "",
                        FirearmName = d["FirearmName"] != DBNull.Value ? d["FirearmName"].ToString().Trim() : "",
                        BarrelLength = d["BarrelLen"] != DBNull.Value ? d["BarrelLen"].ToString().Trim() : "",
                        ConfigName = d["ConfigName"] != DBNull.Value ? d["ConfigName"].ToString().Trim() : "",
                        Notes = d["notes"] != DBNull.Value ? d["notes"].ToString().Trim() : "",
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
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogMetallicData&gt;.</returns>
        public static List<LoadersLogMetallicData> GetDetails(string databasePath, int id, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_NSG where ID={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configName">Name of the configuration.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogMetallicData&gt;.</returns>
        public static List<LoadersLogMetallicData> GetDetails(string databasePath, string configName, string dateCreated, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_NSG where ConfigName='{configName}' and dt=cDate('{dateCreated}')";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogMetallicData&gt;.</returns>
        public static List<LoadersLogMetallicData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_NSG order by ConfigName ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogMetallicData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<LoadersLogMetallicData> GetList(string databasePath, string sql, out string errOut)
        {
            List<LoadersLogMetallicData> lst = new List<LoadersLogMetallicData>();
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
        /// Gets the identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configName">Name of the configuration.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, string configName, string dateCreated, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from Loaders_Log_NSG where configName='{configName}' and dt=cDate('{dateCreated}')";
                List<LoadersLogMetallicData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (LoadersLogMetallicData i in lst)
                {
                    lAns = i.Id;
                    break;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetFirearmId", e);
            }
            return lAns;
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
                List<LoadersLogMetallicData> lst = GetAll(databasePath, out errOut);
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
        /// <param name="configName">Name of the configuration.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, string configName, string dateCreated, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<LoadersLogMetallicData> lst = GetDetails(databasePath, configName, dateCreated, out errOut);
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
        /// <param name="firearmId">The firearm identifier.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="yards">The yards.</param>
        /// <param name="groupSize">Size of the group.</param>
        /// <param name="numberOfShots">The number of shots.</param>
        /// <param name="powderDetails">The powder details.</param>
        /// <param name="bulletDetails">The bullet details.</param>
        /// <param name="primerDetails">The primer details.</param>
        /// <param name="caseDetails">The case details.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="oal">The oal.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="configName">Name of the configuration.</param>
        /// <param name="FirearmName">Name of the firearm.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="BarrelLenght">The barrel lenght.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, long firearmId, string dateCreated, int yards,
            string groupSize, int numberOfShots, string powderDetails, string bulletDetails, 
            string primerDetails, string caseDetails, string condition, string oal, string notes, 
            string configName, string FirearmName, string caliber, string BarrelLenght, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"INSERT INTO Loaders_Log_NSG (fid,dt,yds,gs,ns,pwm,bullet,primer," +
                    $"case,conditions,tl,notes,ConfigName,FirearmName,Caliber,BarrelLen, sync_lastupdate) " +
                    $"VALUES({firearmId},'{dateCreated}', {yards}, '{groupSize}', " +
                    $"{numberOfShots}, '{powderDetails}', '{bulletDetails}', '{primerDetails}', '{caseDetails}', " +
                    $"'{condition}', '{oal}', '{notes}', '{configName}', '{FirearmName}', " +
                    $"'{caliber}', '{BarrelLenght}', Now())";

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
        /// <param name="firearmId">The firearm identifier.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="yards">The yards.</param>
        /// <param name="groupSize">Size of the group.</param>
        /// <param name="numberOfShots">The number of shots.</param>
        /// <param name="powderDetails">The powder details.</param>
        /// <param name="bulletDetails">The bullet details.</param>
        /// <param name="primerDetails">The primer details.</param>
        /// <param name="caseDetails">The case details.</param>
        /// <param name="condition">The condition.</param>
        /// <param name="oal">The oal.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="configName">Name of the configuration.</param>
        /// <param name="FirearmName">Name of the firearm.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="BarrelLenght">The barrel lenght.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, long firearmId, string dateCreated, int yards,
            string groupSize, int numberOfShots, string powderDetails, string bulletDetails,
            string primerDetails, string caseDetails, string condition, string oal, string notes,
            string configName, string FirearmName, string caliber, string BarrelLenght, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"UPDATE Loaders_Log_NSG set fid={firearmId}," +
                    $"dt='{dateCreated}',yds={yards}," +
                    $"gs='{groupSize}',ns={numberOfShots},pwm='{powderDetails}'," +
                    $"bullet='{bulletDetails}',primer='{primerDetails}'," +
                    $"case='{caseDetails}',conditions='{condition}',tl='{oal}'," +
                    $"notes='{notes}',ConfigName='{configName}',FirearmName='{FirearmName}'," +
                    $"Caliber='{caliber}',BarrelLen='{BarrelLenght}', sync_lastupdate=Now() where id={id}";

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
                string sql = $"DELETE from Loaders_Log_NSG where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }
            return bAns;
        }
        /// <summary>
        /// Deletes the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configName">Name of the configuration.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Delete(string databasePath, string configName, string dateCreated, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                long id = GetId(databasePath, configName, dateCreated, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = Delete(databasePath, id, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }
            return bAns;
        }
    }
}
