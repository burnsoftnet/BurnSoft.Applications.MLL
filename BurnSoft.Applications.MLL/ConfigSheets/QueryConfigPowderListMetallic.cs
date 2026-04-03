using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.ConfigSheets
{
    /// <summary>
    /// Class QueryConfigPowderListMetallic data handler for the qry_CFG_SR_PowderList query
    /// </summary>
    public class QueryConfigPowderListMetallic
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.ConfigSheets.QueryConfigPowderListMetallic";

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
        /// <returns>List&lt;QueryConfigPowderListData&gt;.</returns>
        private static List<QueryConfigPowderListData> GetData(DataTable dt, out string errOut)
        {
            List<QueryConfigPowderListData> lst = new List<QueryConfigPowderListData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new QueryConfigPowderListData()
                    {
                        ConfigId = Convert.ToInt32(d["CLNID"]),
                        ConfigName = d["ConfigName"] != DBNull.Value ? d["ConfigName"].ToString().Trim() : "",
                        IsPersonal = Convert.ToInt32(d["IsPersonal"]) == 1 ? true : false,
                        IsShotGun = Convert.ToInt32(d["IsShotGun"]) == 1 ? true : false,
                        CaliberName = d["Cal"] != DBNull.Value ? d["Cal"].ToString().Trim() : "",
                        CaliberId = Convert.ToInt32(d["MyCalID"]),
                        PowderManufacturer = d["General_Powder.Manufacturer"] != DBNull.Value ? d["General_Powder.Manufacturer"].ToString().Trim() : "",
                        PowderName = d["General_Powder.Name"] != DBNull.Value ? d["General_Powder.Name"].ToString().Trim() : "",
                        IsDefaultChargeLoad = Convert.ToInt32(d["IsPref"]) == 1 ? true : false,
                        LoadMin = Convert.ToDouble(d["Load_Min"]),
                        LoadMid = Convert.ToDouble(d["Load_Mid"]),
                        LoadMax = Convert.ToDouble(d["Load_Max"]),
                        FpsMin = Convert.ToDouble(d["FPS_Min"]),
                        FpsMid = Convert.ToDouble(d["FPS_Mid"]),
                        FpsMax = Convert.ToDouble(d["FPS_Max"]),
                        CupsMin = Convert.ToDouble(d["CUPS_Min"]),
                        CupsMid = Convert.ToDouble(d["CUPS_Mid"]),
                        CupsMax = Convert.ToDouble(d["CUPS_Max"]),
                        BulletManufacturer = d["List_Bullets.Manufacturer"] != DBNull.Value ? d["List_Bullets.Manufacturer"].ToString().Trim() : "",
                        BulletName = d["List_Bullets.Name"] != DBNull.Value ? d["List_Bullets.Name"].ToString().Trim() : "",
                        BulletDiameter = d["Diameter"] != DBNull.Value ? d["Diameter"].ToString().Trim() : "",
                        BulletWeight = d["Weight"] != DBNull.Value ? d["Weight"].ToString().Trim() : "",

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
        /// <returns>List&lt;QueryConfigPowderListData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<QueryConfigPowderListData> GetList(string databasePath, string sql, out string errOut)
        {
            List<QueryConfigPowderListData> lst = new List<QueryConfigPowderListData>();
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
        /// <returns>List&lt;QueryConfigPowderListData&gt;.</returns>
        public static List<QueryConfigPowderListData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from qry_CFG_SR_PowderList order by ConfigName ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;QueryConfigPowderListData&gt;.</returns>
        public static List<QueryConfigPowderListData> GetDetails(string databasePath, string name, out string errOut)
        {
            string sql = $"Select * from qry_CFG_SR_PowderList where ConfigName='{name}'";
            return GetList(databasePath, sql, out errOut);
        }

        public static List<QueryConfigPowderListData> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from qry_CFG_SR_PowderList where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
    }
}
