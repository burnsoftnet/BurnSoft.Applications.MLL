using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.Global
{
    /// <summary>
    /// Class Wishlists handles the data in the wishlist table
    /// </summary>
    public class Wishlists
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Search.SyncTables";

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
        /// <returns>List&lt;WishlistData&gt;.</returns>
        private static List<WishlistData> GetData(DataTable dt, out string errOut)
        {
            List<WishlistData> lst = new List<WishlistData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new WishlistData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Manufacturer = d["Manufacturer"] != DBNull.Value ? d["Manufacturer"].ToString().Trim() : "",
                        Model = d["Model"] != DBNull.Value ? d["Model"].ToString().Trim() : "",
                        PlaceToBuy = d["PlaceToBuy"] != DBNull.Value ? d["PlaceToBuy"].ToString().Trim() : "",
                        Qty = d["Qty"] != DBNull.Value ? d["Qty"].ToString().Trim() : "",
                        Value = d["Value"] != DBNull.Value ? d["Value"].ToString().Trim() : "",
                        Notes = d["Notes"] != DBNull.Value ? d["Notes"].ToString().Trim() : "",
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
        /// <returns>List&lt;WishlistData&gt;.</returns>
        public static List<WishlistData> GetDetails(string databasePath, int id, out string errOut)
        {
            string sql = $"Select * from wishlist where ID={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="model">The model.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;WishlistData&gt;.</returns>
        public static List<WishlistData> GetDetails(string databasePath, string manufacturer, string model, out string errOut)
        {
            string sql = $"Select * from wishlist where Manufacturer='{manufacturer}' and Model='{model}'";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;WishlistData&gt;.</returns>
        public static List<WishlistData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from wishlist order by tblname ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;WishlistData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<WishlistData> GetList(string databasePath, string sql, out string errOut)
        {
            List<WishlistData> lst = new List<WishlistData>();
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
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="model">The model.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, string manufacturer, string model, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from wishlist where manufacturer='{manufacturer}' and model='{model}'";
                List<WishlistData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (WishlistData i in lst)
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
                List<WishlistData> lst = GetAll(databasePath, out errOut);
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
        /// <param name="model">The model.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, string manufacturer, string model, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<WishlistData> lst = GetDetails(databasePath, manufacturer, model, out errOut);
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
        /// <param name="model">The model.</param>
        /// <param name="placeToBuy">The place to buy.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="value">The value.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string manufacturer, string model, 
            string placeToBuy, string qty, string value, string notes, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"INSERT INTO wishlist (Manufacturer, Model, PlaceToBuy, Qty, Value, Notes) " +
                    $"VALUES('{manufacturer}', '{model}', '{placeToBuy}', '{qty}', '{value}', '{notes}')";

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
        /// <param name="model">The model.</param>
        /// <param name="placeToBuy">The place to buy.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="value">The value.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, string manufacturer, string model,
            string placeToBuy, string qty, string value, string notes, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"UPDATE wishlist set Manufacturer='{manufacturer}', model='{model}', " +
                    $"placeToBuy='{placeToBuy}', qty='{qty}', value='{value}', notes='{notes}'  where id={id}";

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
                string sql = $"DELETE from wishlist where id={id}";
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
        /// <param name="model">The model.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Delete(string databasePath, string manufacturer, string model, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                long id = GetId(databasePath, manufacturer, model, out errOut);
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
