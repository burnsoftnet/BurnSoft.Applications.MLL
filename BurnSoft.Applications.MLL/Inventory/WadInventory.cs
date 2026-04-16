using BurnSoft.Applications.MLL.Helpers;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;


namespace BurnSoft.Applications.MLL.Inventory
{
    /// <summary>
    /// Class WadInventory handles the data in the  List_SG_WAD table
    /// </summary>
    public class WadInventory
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.WadInventory";

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
        /// <returns>List&lt;WadData&gt;.</returns>
        private static List<WadData> GetData(DataTable dt, out string errOut)
        {
            List<WadData> lst = new List<WadData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new WadData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Manufacturer = d["Manufacturer"] != DBNull.Value ? d["Manufacturer"].ToString().Trim() : "",
                        Name = d["WAD"] != DBNull.Value ? d["WAD"].ToString().Trim() : "",
                        Gauge = d["Gauge"] != DBNull.Value ? d["Gauge"].ToString().Trim() : "",
                        GaugeId = Convert.ToInt32(d["GID"]),
                        LoadInOzText = d["load_t"] != DBNull.Value ? d["load_t"].ToString().Trim() : "",
                        Qty = Convert.ToInt32(d["Qty"]),
                        Price = Convert.ToDouble(d["Price"]),
                        LoadInOz = Convert.ToDouble(d["load_d"]),
                        EstimatedPricePerItem = Convert.ToDouble(d["eppw"]),
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
        /// <returns>List&lt;WadData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<WadData> GetList(string databasePath, string sql, out string errOut)
        {
            List<WadData> lst = new List<WadData>();
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
        /// <returns>List&lt;WadData&gt;.</returns>
        public static List<WadData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from List_SG_WAD order by Manufacturer,WAD  ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="gauge">The gauge.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, string manufacturer, string name, string gauge, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from List_SG_WAD where manufacturer='{manufacturer}' and WAD='{name}' and gauge='{gauge}'";
                List<WadData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (WadData i in lst)
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
        /// Gets the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        public static string GetName(string databasePath, long id, out string errOut)
        {
            errOut = "";
            string sAns = "";
            try
            {
                string sql = $"Select * from List_SG_WAD where id={id}";
                List<WadData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (WadData i in lst)
                {
                    sAns = i.Name;
                    break;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetName", e);
            }
            return sAns;
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="gauge">The gauge.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;WadData&gt;.</returns>
        public static List<WadData> GetDetails(string databasePath, string manufacturer, string name, string gauge, out string errOut)
        {
            string sql = $"Select * from List_SG_WAD where manufacturer='{manufacturer}' and WAD='{name}' and Gauge='{gauge}'";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;WadData&gt;.</returns>
        public static List<WadData> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from List_SG_WAD where id={id}";
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
                List<WadData> lst = GetAll(databasePath, out errOut);
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
        /// <param name="gauge">The gauge.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, string manufacturer, string name, string gauge, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<WadData> lst = GetDetails(databasePath, manufacturer, name, gauge, out errOut);
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
        /// <param name="gauge">The gauge.</param>
        /// <param name="gaugeId">The gun identifier.</param>
        /// <param name="load">The load.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="preFluffEn">if set to <c>true</c> [pre fluff en].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Add(string databasePath, string manufacturer, string name, string gauge,
            long gaugeId, string load, int qty, double price, out string errOut, bool preFluffEn = false)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                if (preFluffEn)
                {
                    manufacturer = GeneralHelpers.FluffContent(manufacturer);
                    name = GeneralHelpers.FluffContent(name);
                    gauge = GeneralHelpers.FluffContent(gauge);
                    load = GeneralHelpers.FluffContent(load);
                }
                double loadDouble = Converters.ConvertOzToDouble(load, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                double estCostPerItem = (price == 0) ? 0 : (price / qty);
                string sql = $"INSERT INTO List_SG_WAD(Manufacturer,WAD,Gauge," +
                    $"GID,load_t,load_d,Qty,Price,eppw, sync_lastupdate) VALUES(" +
                    $"'{manufacturer}', '{name}', '{gauge}', {gaugeId}, '{load}'," +
                    $"{loadDouble},{qty}, {price}, {estCostPerItem}, Now())";

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
        /// <param name="gauge">The gauge.</param>
        /// <param name="guageId">The guage identifier.</param>
        /// <param name="load">The load.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="preFluffEn">if set to <c>true</c> [pre fluff en].</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Update(string databasePath, long id, string manufacturer, string name, string gauge,
            long guageId, string load, int qty, double price, out string errOut, bool preFluffEn = false)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                if (preFluffEn)
                {
                    manufacturer = GeneralHelpers.FluffContent(manufacturer);
                    name = GeneralHelpers.FluffContent(name);
                    gauge = GeneralHelpers.FluffContent(gauge);
                    load = GeneralHelpers.FluffContent(load);
                }
                double loadDouble = Converters.ConvertOzToDouble(load, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                double estCostPerItem = (price == 0) ? 0 : (price / qty);
                string sql = $"UPDATE List_SG_WAD set Manufacturer='{manufacturer}'," +
                    $"WAD='{name}',Gauge='{gauge}',GID={guageId}, " +
                    $"load_t='{load}', load_d={loadDouble}, Qty={qty}, Price={price}, " +
                    $"eppw={estCostPerItem}, sync_lastupdate=Now() where id={id}";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, int qty, double price, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                double estCostPerItem = (price == 0) ? 0 : (price / qty);
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE List_SG_WAD set Qty={qty}," +
                    $"Price={price}, epps={estCostPerItem} where id={id}";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the qty.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="currentQty">The current qty.</param>
        /// <param name="currentPrice">The current price.</param>
        /// <param name="currentPricePerItem">The current price per item.</param>
        /// <param name="newQty">The new qty.</param>
        /// <param name="NewPrice">Creates new price.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool UpdateQty(string databasePath, long id, int currentQty, double currentPrice,
            double currentPricePerItem, int newQty, double NewPrice, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int qty = currentQty + newQty;
                double price = (currentQty * currentPricePerItem) + NewPrice;
                double estCostPerItem = Converters.ConvertToDollars((price == 0) ? 0 : (price / qty));
                string sql = $"UPDATE List_SG_WAD set Qty={qty}," +
                    $"Price={price}, eppw={estCostPerItem} where id={id}";

                if (currentPricePerItem == estCostPerItem)
                {
                    sql = $"UPDATE List_SG_WAD set Qty={newQty}," +
                    $"Price={NewPrice} where id={id}";
                }
                else if (NewPrice == 0 && newQty == 0)
                {
                    sql = $"UPDATE List_SG_WAD set Qty=0, Price=0, eppw=0 where id={id}";
                }

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateQty", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the qty.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="newQty">The new qty.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool UpdateQty(string databasePath, long id, int newQty, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"UPDATE List_SG_WAD set Qty={newQty} where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateQty", e);
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
                string sql = $"DELETE from List_SG_WAD where id={id}";
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
        /// <param name="gauge">The gauge.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Delete(string databasePath, string manufacturer, string name, 
            string gauge, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                long id = GetId(databasePath, manufacturer, name, gauge, out errOut);
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
