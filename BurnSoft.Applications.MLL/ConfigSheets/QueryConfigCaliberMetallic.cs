using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.ConfigSheets
{
    /// <summary>
    /// Class QueryConfigCaliberMetallic work with the qry_ConfigCal_NSG Query.
    /// </summary>
    public class QueryConfigCaliberMetallic
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.ConfigSheets.QueryConfigCaliberMetallic";

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
        /// <returns>List&lt;QueryConfigCaliberMetallicData&gt;.</returns>
        private static List<QueryConfigCaliberMetallicData> GetData(DataTable dt, out string errOut)
        {
            List<QueryConfigCaliberMetallicData> lst = new List<QueryConfigCaliberMetallicData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new QueryConfigCaliberMetallicData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Name = d["ConfigName"] != DBNull.Value ? d["ConfigName"].ToString().Trim() : "",
                        CaliberId = Convert.ToInt32(d["CALID"]),
                        IsPersonal = Convert.ToInt32(d["IsPersonal"]) == 1 ? true : false,
                        IsShotGun = Convert.ToInt32(d["IsShotGun"]) == 1 ? true : false,
                        IsActive = Convert.ToInt32(d["IsActive"]) == 1 ? true : false,
                        IsFavorite = Convert.ToInt32(d["IsFav"]) == 1 ? true : false,
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
        /// <returns>List&lt;QueryConfigCaliberMetallicData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<QueryConfigCaliberMetallicData> GetList(string databasePath, string sql, out string errOut)
        {
            List<QueryConfigCaliberMetallicData> lst = new List<QueryConfigCaliberMetallicData>();
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
        /// <returns>List&lt;QueryConfigCaliberMetallicData&gt;.</returns>
        public static List<QueryConfigCaliberMetallicData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from qry_ConfigCal_NSG order by ConfigName ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, string name, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from qry_ConfigCal_NSG where ConfigName='{name}'";
                List<QueryConfigCaliberMetallicData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (QueryConfigCaliberMetallicData i in lst)
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
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;QueryConfigCaliberMetallicData&gt;.</returns>
        public static List<QueryConfigCaliberMetallicData> GetDetails(string databasePath, string name, out string errOut)
        {
            string sql = $"Select * from qry_ConfigCal_NSG where ConfigName='{name}'";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;QueryConfigCaliberMetallicData&gt;.</returns>
        public static List<QueryConfigCaliberMetallicData> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from qry_ConfigCal_NSG where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details by caliber identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;QueryConfigCaliberMetallicData&gt;.</returns>
        public static List<QueryConfigCaliberMetallicData> GetDetailsByCaliberId(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from qry_ConfigCal_NSG where CalID={id}";
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
                List<QueryConfigCaliberMetallicData> lst = GetAll(databasePath, out errOut);
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
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, string name, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                List<QueryConfigCaliberMetallicData> lst = GetDetails(databasePath, name, out errOut);
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
        /// Datas the exists by caliber identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExistsByCaliberId(string databasePath, long id, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                List<QueryConfigCaliberMetallicData> lst = GetDetailsByCaliberId(databasePath, id, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExistsByCaliberId", e);
            }
            return bAns;
        }
    }
}
