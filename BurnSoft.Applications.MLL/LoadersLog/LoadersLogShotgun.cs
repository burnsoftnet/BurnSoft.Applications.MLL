using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.LoadersLog
{
    /// <summary>
    /// Class LoadersLogShotgun handles the data in the Loaders_Log_SG table..
    /// </summary>
    public class LoadersLogShotgun
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.LoadersLog.LoadersLogShotgun";

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
        /// <returns>List&lt;LoadersLogShotgunData&gt;.</returns>
        private static List<LoadersLogShotgunData> GetData(DataTable dt, out string errOut)
        {
            List<LoadersLogShotgunData> lst = new List<LoadersLogShotgunData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new LoadersLogShotgunData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        FirearmId = Convert.ToInt32(d["fid"]),
                        FirearmName = d["FirearmName"] != DBNull.Value ? d["FirearmName"].ToString().Trim() : "",
                        Caliber = d["Caliber"] != DBNull.Value ? d["Caliber"].ToString().Trim() : "",
                        BarrelLength = d["BarrelLen"] != DBNull.Value ? d["BarrelLen"].ToString().Trim() : "",
                        ConfigName = d["ConfigName"] != DBNull.Value ? d["ConfigName"].ToString().Trim() : "",
                        DateCreated = d["dt"] != DBNull.Value ? Convert.ToDateTime(d["dt"].ToString().Trim()) : DateTime.Now,
                        ShotWeight = d["Shotwt"] != DBNull.Value ? d["Shotwt"].ToString().Trim() : "",
                        ShotSize = d["ShotSize"] != DBNull.Value ? d["ShotSize"].ToString().Trim() : "",
                        CaseDetails = d["case"] != DBNull.Value ? d["case"].ToString().Trim() : "",
                        PowderDetails = d["pbm"] != DBNull.Value ? d["pbm"].ToString().Trim() : "",
                        WadDetails = d["wad"] != DBNull.Value ? d["wad"].ToString().Trim() : "",
                        PrimerDetails = d["primer"] != DBNull.Value ? d["primer"].ToString().Trim() : "",
                        PatternDensity = d["pd"] != DBNull.Value ? d["pd"].ToString().Trim() : "",
                        Yards = Convert.ToInt32(d["yds"]),
                        Notes = d["notes"] != DBNull.Value ? d["notes"].ToString().Trim() : "",
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
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogShotgunData&gt;.</returns>
        public static List<LoadersLogShotgunData> GetDetails(string databasePath, int id, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_SG where ID={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configName">Name of the configuration.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogShotgunData&gt;.</returns>
        public static List<LoadersLogShotgunData> GetDetails(string databasePath, string configName, string dateCreated, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_SG where ConfigName='{configName}' and dt=cDate('{dateCreated}')";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogShotgunData&gt;.</returns>
        public static List<LoadersLogShotgunData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_SG order by ConfigName ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogShotgunData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<LoadersLogShotgunData> GetList(string databasePath, string sql, out string errOut)
        {
            List<LoadersLogShotgunData> lst = new List<LoadersLogShotgunData>();
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
                string sql = $"Select * from Loaders_Log_SG where configName='{configName}' and dt=cDate('{dateCreated}')";
                List<LoadersLogShotgunData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (LoadersLogShotgunData i in lst)
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
                List<LoadersLogShotgunData> lst = GetAll(databasePath, out errOut);
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

                List<LoadersLogShotgunData> lst = GetDetails(databasePath, configName, dateCreated, out errOut);
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
        /// <param name="fireArmName">Name of the fire arm.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="BarrelLenght">The barrel lenght.</param>
        /// <param name="ConfigName">Name of the configuration.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="shotWeight">The shot weight.</param>
        /// <param name="shotSize">Size of the shot.</param>
        /// <param name="caseDetails">The case details.</param>
        /// <param name="powderDetails">The powder details.</param>
        /// <param name="wadDetails">The wad details.</param>
        /// <param name="primerDetails">The primer details.</param>
        /// <param name="patterDensity">The patter density.</param>
        /// <param name="yards">The yards.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, long firearmId, string fireArmName, string caliber,
            string BarrelLenght, string ConfigName, string dateCreated, string shotWeight,
            string shotSize, string caseDetails, string powderDetails, string wadDetails, string primerDetails,
            string patterDensity, int yards, string notes, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"INSERT INTO Loaders_Log_SG (fid,FirearmName,Caliber,BarrelLen,ConfigName,dt," +
                    $"Shotwt,ShotSize,case,pbm,wad,primer,pd,yds,notes, sync_lastupdate) " +
                    $"VALUES({firearmId},'{fireArmName}', '{caliber}', '{BarrelLenght}', " +
                    $"'{ConfigName}', '{dateCreated}', '{shotWeight}', '{shotSize}', '{caseDetails}', " +
                    $"'{powderDetails}', '{wadDetails}', '{primerDetails}', '{patterDensity}', {yards}, " +
                    $"'{notes}', Now())";

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
        /// <param name="fireArmName">Name of the fire arm.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="BarrelLenght">The barrel lenght.</param>
        /// <param name="ConfigName">Name of the configuration.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="shotWeight">The shot weight.</param>
        /// <param name="shotSize">Size of the shot.</param>
        /// <param name="caseDetails">The case details.</param>
        /// <param name="powderDetails">The powder details.</param>
        /// <param name="wadDetails">The wad details.</param>
        /// <param name="primerDetails">The primer details.</param>
        /// <param name="patterDensity">The patter density.</param>
        /// <param name="yards">The yards.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, long firearmId, string fireArmName, string caliber,
            string BarrelLenght, string ConfigName, string dateCreated, string shotWeight,
            string shotSize, string caseDetails, string powderDetails, string wadDetails, string primerDetails,
            string patterDensity, int yards, string notes, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"UPDATE Loaders_Log_SG set fid={firearmId},FirearmName='{fireArmName}'," +
                    $"Caliber='{caliber}',BarrelLen='{BarrelLenght}',ConfigName='{ConfigName}',dt=CDate('{dateCreated}')," +
                    $"Shotwt='{shotWeight}',ShotSize='{shotSize}',case='{caseDetails}',pbm='{powderDetails}'," +
                    $"wad='{wadDetails}',primer='{primerDetails}',pd='{patterDensity}',yds={yards},notes='{notes}', " +
                    $"sync_lastupdate=Now() where id={id}";

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
                string sql = $"DELETE from Loaders_Log_SG where id={id}";
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
