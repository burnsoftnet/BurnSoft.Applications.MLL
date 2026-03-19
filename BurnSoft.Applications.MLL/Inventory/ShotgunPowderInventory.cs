using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.Inventory
{
    /// <summary>
    /// Class ShotgunPowderInventory works with the data in the List_SG_Bushing_Powder_Powder table.
    /// </summary>
    public class ShotgunPowderInventory
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.ShotgunPowderInventory";

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
        /// <returns>List&lt;ShotgunPowderListings&gt;.</returns>
        private static List<ShotgunPowderListings> GetData(DataTable dt, out string errOut)
        {
            List<ShotgunPowderListings> lst = new List<ShotgunPowderListings>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new ShotgunPowderListings()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Manufacturer = d["Manufacturer"] != DBNull.Value ? d["Manufacturer"].ToString().Trim() : "",
                        Name = d["sName"] != DBNull.Value ? d["sName"].ToString().Trim() : "",
                        Charge = d["sCharge"] != DBNull.Value ? d["sCharge"].ToString().Trim() : "",
                        Type = d["sType"] != DBNull.Value ? d["sType"].ToString().Trim() : "",
                        PowderName = d["PowderName"] != DBNull.Value ? d["PowderName"].ToString().Trim() : "",
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
        /// <returns>List&lt;ShotgunPowderListings&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<ShotgunPowderListings> GetList(string databasePath, string sql, out string errOut)
        {
            List<ShotgunPowderListings> lst = new List<ShotgunPowderListings>();
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
        /// <returns>List&lt;ShotgunPowderListings&gt;.</returns>
        public static List<ShotgunPowderListings> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from List_SG_Bushing_Powder order by Manufacturer,sName  ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, string manufacturer, string name, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from List_SG_Bushing_Powder where manufacturer='{manufacturer}' and sname='{name}'";
                List<ShotgunPowderListings> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (ShotgunPowderListings i in lst)
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
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ShotgunPowderListings&gt;.</returns>
        public static List<ShotgunPowderListings> GetDetails(string databasePath, string manufacturer, string name, out string errOut)
        {
            string sql = $"Select * from List_SG_Bushing_Powder where manufacturer='{manufacturer}' and sname='{name}'";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ShotgunPowderListings&gt;.</returns>
        public static List<ShotgunPowderListings> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from List_SG_Bushing_Powder where id={id}";
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
                List<ShotgunPowderListings> lst = GetAll(databasePath, out errOut);
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
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, string manufacturer, string name, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<ShotgunPowderListings> lst = GetDetails(databasePath, manufacturer, name, out errOut);
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
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="charge">The charge.</param>
        /// <param name="type">The type.</param>
        /// <param name="powderName">Name of the powder.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string manufacturer, string name, string charge,
            string type, string powderName, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"INSERT INTO List_SG_Bushing_Powder(Manufacturer,sName,sCharge," +
                    $"sType,PowderName) VALUES(" +
                    $"'{o.FC(manufacturer)}', '{o.FC(name)}', '{o.FC(charge)}', " +
                    $"'{type}', '{powderName}')";

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
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="charge">The charge.</param>
        /// <param name="type">The type.</param>
        /// <param name="powderName">Name of the powder.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, string manufacturer,
            string name, string charge, string type, string powderName, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {

                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE List_SG_Bushing_Powder set Manufacturer='{o.FC(manufacturer)}'," +
                    $"sName='{o.FC(name)}',sCharge='{o.FC(charge)}', sType='{type}', " +
                    $"PowderName='{powderName}' where id={id}";

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
                string sql = $"DELETE from List_SG_Bushing_Powder where id={id}";
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
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Delete(string databasePath, string manufacturer, string name, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                long id = GetId(databasePath, manufacturer, name, out errOut);
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
