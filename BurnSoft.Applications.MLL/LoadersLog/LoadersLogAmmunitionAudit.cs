using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;
using System.Data;


namespace BurnSoft.Applications.MLL.LoadersLog
{
    /// <summary>
    /// Class LoadersLogAmmunition handles the data in the 
    /// Loaders_Log_Ammunition_Audit_Audit 
    /// </summary>
    public class LoadersLogAmmunitionAudit
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.LoadersLogAmmunitionAudit";

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
        /// <returns>List&lt;LoadersLogAmmunitionAuditData&gt;.</returns>
        private static List<LoadersLogAmmunitionAuditData> GetData(DataTable dt, out string errOut)
        {
            List<LoadersLogAmmunitionAuditData> lst = new List<LoadersLogAmmunitionAuditData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new LoadersLogAmmunitionAuditData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        ConfigId = Convert.ToInt32(d["CFID"]),
                        DateCreated = d["dtc"] != DBNull.Value ? d["dtc"].ToString().Trim() : "",
                        Qty = Convert.ToInt32(d["Qty"]),
                        EstimatedCostToMakeTotal = Convert.ToDouble(d["ec"]),
                        EstimatedCostToMalePerRound = Convert.ToDouble(d["ecpr"]),
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
        /// <returns>List&lt;LoadersLogAmmunitionAuditData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<LoadersLogAmmunitionAuditData> GetList(string databasePath, string sql, out string errOut)
        {
            List<LoadersLogAmmunitionAuditData> lst = new List<LoadersLogAmmunitionAuditData>();
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
        /// <returns>List&lt;LoadersLogAmmunitionAuditData&gt;.</returns>
        public static List<LoadersLogAmmunitionAuditData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_Ammunition_Audit order by CFID ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, long configId, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from Loaders_Log_Ammunition_Audit where CFID={configId}";
                List<LoadersLogAmmunitionAuditData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (LoadersLogAmmunitionAuditData i in lst)
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
        /// <returns>List&lt;LoadersLogAmmunitionAuditData&gt;.</returns>
        public static List<LoadersLogAmmunitionAuditData> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_Ammunition_Audit where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;LoadersLogAmmunitionAuditData&gt;.</returns>
        public static List<LoadersLogAmmunitionAuditData> GetDetails(string databasePath, int configId, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_Ammunition_Audit where cfid={configId}";
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
                List<LoadersLogAmmunitionAuditData> lst = GetAll(databasePath, out errOut);
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
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, long id, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<LoadersLogAmmunitionAuditData> lst = GetDetails(databasePath, id, out errOut);
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
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, int configId, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<LoadersLogAmmunitionAuditData> lst = GetDetails(databasePath, configId, out errOut);
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
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="estimatedTotalCost">The estimated total cost.</param>
        /// <param name="estimatedCostPerRound">The estimated cost per round.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Add(string databasePath, long configId, string dateCreated, long qty,
            double estimatedTotalCost, double estimatedCostPerRound, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                if (errOut.Length > 0) throw new Exception(errOut);
                string sql = $"INSERT INTO Loaders_Log_Ammunition_Audit(CFID,dtc,qty," +
                    $"ec,ecpr,sync_lastupdate) VALUES(" +
                    $"{configId}, '{dateCreated}', {qty}, " +
                    $"{estimatedTotalCost}, {estimatedCostPerRound}, Now())";

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
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="dateCreated">The date created.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="estimatedTotalCost">The estimated total cost.</param>
        /// <param name="estimatedCostPerRound">The estimated cost per round.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Update(string databasePath, long id, long configId, string dateCreated, 
            long qty, double estimatedTotalCost, double estimatedCostPerRound, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                if (errOut.Length > 0) throw new Exception(errOut);
                string sql = $"UPDATE Loaders_Log_Ammunition_Audit set CFID={configId}," +
                    $"dtc='{dateCreated}',qty={qty},ec={estimatedTotalCost}, " +
                    $"ecpr={estimatedCostPerRound}, sync_lastupdate=Now() where id={id}";

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
                string sql = $"DELETE from Loaders_Log_Ammunition_Audit where id={id}";
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
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Delete(string databasePath, int configId, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                long id = GetId(databasePath, configId, out errOut);
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
