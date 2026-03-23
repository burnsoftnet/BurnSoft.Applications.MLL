using BurnSoft.Applications.MLL.Helpers;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;


namespace BurnSoft.Applications.MLL.Inventory
{
    /// <summary>
    /// Class PrimerInventory handles working with the data in the General_Primer Table.
    /// </summary>
    public class PrimerInventory
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.PrimerInventory";

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
        /// <param name="databasePath">The database path.</param>
        /// <param name="dt">The dt.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PrimerListings&gt;.</returns>
        private static List<PrimerListings> GetData(string databasePath, DataTable dt, out string errOut)
        {
            List<PrimerListings> lst = new List<PrimerListings>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    int primerTypeId = Convert.ToInt32(d["Primer_Type"]);
                    int id = Convert.ToInt32(d["id"]);
                    lst.Add(new PrimerListings()
                    {
                        Id = id,
                        Manufacturer = d["Manufacturer"] != DBNull.Value ? d["Manufacturer"].ToString().Trim() : "",
                        Name = d["Name"] != DBNull.Value ? d["Name"].ToString().Trim() : "",
                        PrimerTypeId = primerTypeId,
                        PrimerType = PrimerTypes.GetName(databasePath, id, out _),
                        Price = Convert.ToDouble(d["Price"]),
                        Qty = Convert.ToInt32(d["qty"]),
                        PricePerPrimer = Convert.ToDouble(d["ePPP"]),
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
        /// <returns>List&lt;PrimerListings&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<PrimerListings> GetList(string databasePath, string sql, out string errOut)
        {
            List<PrimerListings> lst = new List<PrimerListings>();
            errOut = "";
            try
            {
                DataTable dt = Database.GetDataFromTable(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                lst = GetData(databasePath, dt, out errOut);
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
        /// <returns>List&lt;PrimerListings&gt;.</returns>
        public static List<PrimerListings> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from General_Primer order by Manufacturer,Name  ASC";
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
                string sql = $"Select * from General_Primer where manufacturer='{manufacturer}' and name='{name}'";
                List<PrimerListings> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (PrimerListings i in lst)
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
        /// Gets the type of the primer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        public static string GetPrimerType(string databasePath, long id, out string errOut)
        {
            errOut = "";
            string sAns = "";
            try
            {
                string sql = $"Select * from General_Primer where id={id}";
                List<PrimerListings> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (PrimerListings i in lst)
                {
                    sAns = i.Name;
                    break;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetPrimerType", e);
            }
            return sAns;
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PrimerListings&gt;.</returns>
        public static List<PrimerListings> GetDetails(string databasePath, string manufacturer, string name, out string errOut)
        {
            string sql = $"Select * from General_Primer where manufacturer='{manufacturer}' and name='{name}'";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PrimerListings&gt;.</returns>
        public static List<PrimerListings> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from General_Primer where id={id}";
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
                List<PrimerListings> lst = GetAll(databasePath, out errOut);
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

                List<PrimerListings> lst = GetDetails(databasePath, manufacturer, name, out errOut);
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
        /// <param name="primerType">Type of the primer.</param>
        /// <param name="price">The price.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Add(string databasePath, string manufacturer, string name, int primerType,
            double price, long qty, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                manufacturer = o.FC(manufacturer);
                name = o.FC(name);

                if (errOut.Length > 0) throw new Exception(errOut);
                double PricePerPrimer = CalculatePricePerItem(qty, price);
                string sql = $"INSERT INTO General_Primer(Manufacturer,Name,Primer_Type," +
                    $"Price,Qty, ePPP, sync_lastupdate) VALUES(" +
                    $"'{manufacturer}', '{name}', {primerType}, " +
                    $"{price}, {qty}, {PricePerPrimer},Now())";

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
        /// <param name="primerType">Type of the primer.</param>
        /// <param name="price">The price.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Update(string databasePath, long id, string manufacturer, string name, int primerType,
            double price, long qty, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                if (errOut.Length > 0) throw new Exception(errOut);
                double PricePerGrain = (price / qty);
                string sql = $"UPDATE General_Primer set Manufacturer='{o.FC(manufacturer)}'," +
                    $"Name='{o.FC(name)}',Primer_Type={primerType},qty={qty},Price={price}," +
                    $"ePPP={PricePerGrain}, sync_lastupdate=Now() where id={id}";

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
                string sql = $"UPDATE General_Primer set Qty={qty}," +
                    $"Price={price}, eppp={estCostPerItem} where id={id}";

                if (currentPricePerItem == estCostPerItem)
                {
                    sql = $"UPDATE General_Primer set Qty={newQty}," +
                    $"Price={NewPrice} where id={id}";
                }
                else if (NewPrice == 0 && newQty == 0)
                {
                    sql = $"UPDATE General_Primer set Qty=0, Price=0, eppp=0 where id={id}";
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
                string sql = $"DELETE from General_Primer where id={id}";
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
        /// <summary>
        /// Calculates the price per item.
        /// </summary>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="useDollar">if set to <c>true</c> [use dollar].</param>
        /// <returns>System.Double.</returns>
        public static double CalculatePricePerItem(long qty, double price, bool useDollar = false)
        {
            double dAns = 0;
            if (qty > 0)
            {
                dAns = price / qty;
            }

            if (useDollar)
            {
                return Converters.ConvertToDollars(dAns);
            }
            else
            {
                return dAns;
            }
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
        /// <param name="newPrice">The new price.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool UpdateQty(string databasePath, long id, long currentQty, double currentPrice,
            double currentPricePerItem, long newQty, double newPrice, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                double updatedPricePerItem = CalculatePricePerItem(newQty, newPrice);
                long updatedQty = (currentQty + newQty);
                double UpdatedPrice = (currentQty * currentPricePerItem) + newPrice;
                double newPricePerItem = CalculatePricePerItem(updatedQty, UpdatedPrice);
                string sql = "";
                if (currentPricePerItem == updatedPricePerItem)
                {
                    sql = $"UPDATE General_Primer set QTY={updatedQty}, Price={UpdatedPrice} where ID={id}";
                }
                else if ((UpdatedPrice == 0) && (currentQty == 0))
                {
                    sql = $"UPDATE General_Primer set QTY=0, Price=0, eppp=0 where ID={id}";
                }
                else
                {
                    sql = $"UPDATE General_Primer set QTY={updatedQty}, Price={UpdatedPrice}," +
                        $"eppp={newPricePerItem} where ID={id}";
                }
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateQty", e);
            }
            return bAns;
        }
    }
}
