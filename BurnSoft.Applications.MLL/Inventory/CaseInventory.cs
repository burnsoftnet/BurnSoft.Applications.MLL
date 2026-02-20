using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.Applications.MLL.Inventory
{
    /// <summary>
    /// Class CaseInventory handles the ability to interact with the List_Case Table
    /// </summary>
    public class CaseInventory
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.CaseInventory";

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

        private static List<CaseListings> GetData(DataTable dt, out string errOut)
        {
            List<CaseListings> lst = new List<CaseListings>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new CaseListings()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Manufacturer = d["Manufacturer"] != DBNull.Value ? d["Manufacturer"].ToString().Trim() : "",
                        Name = d["Name"] != DBNull.Value ? d["Name"].ToString().Trim() : "",
                        TrimToLength = d["ttl"] != DBNull.Value ? d["ttl"].ToString().Trim() : "",
                        IsNew = Convert.ToInt32(d["IsNew"]) == 1 ? true : false,
                        TimesUsed = Convert.ToInt32(d["TimesUsed"]),
                        Qty = Convert.ToInt32(d["Qty"]),
                        Price = Convert.ToDouble(d["Price"]),
                        CaliberId = Convert.ToInt32(d["CID"]),
                        EstimatedPricePerCase = Convert.ToDouble(d["ePPC"]),
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

        private static List<CaseListings> GetList(string databasePath, string sql, out string errOut)
        {
            List<CaseListings> lst = new List<CaseListings>();
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

        public static List<CaseListings> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from List_Case order by Manufacturer,Name  ASC";
            return GetList(databasePath, sql, out errOut);
        }

        public static long GetId(string databasePath, string manufacturer, string name, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from List_Case where manufacturer='{manufacturer}' and name='{name}'";
                List<CaseListings> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (CaseListings i in lst)
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

        public static List<CaseListings> GetDetails(string databasePath, string manufacturer, string name, out string errOut)
        {
            string sql = $"Select * from List_Case where manufacturer='{manufacturer}' and name='{name}'";
            return GetList(databasePath, sql, out errOut);
        }

        public static List<CaseListings> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from List_Case where id={id}";
            return GetList(databasePath, sql, out errOut);
        }

        public static bool DataExists(string databasePath, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                List<CaseListings> lst = GetAll(databasePath, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExists", e);
            }
            return bAns;
        }

        public static bool DataExists(string databasePath, string manufacturer, string name, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<CaseListings> lst = GetDetails(databasePath, manufacturer, name, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExists", e);
            }
            return bAns;
        }

        public static bool Add(string databasePath, string manufacturer, string name, string ttl,
            bool IsNew, int TimesUsed, int qty, double price, long caliberId, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int iIsNew = IsNew ? 1 : 0;
                double estCostPerItem = (price == 0) ? 0 : (price / qty);
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"INSERT INTO List_Case(Manufacturer,Name,ttl," +
                    $"IsNew,TimesUsed,Qty,Price,CID,ePPC) VALUES(" +
                    $"'{o.FC(manufacturer)}', '{o.FC(name)}', '{o.FC(ttl)}', " +
                    $"{iIsNew}, {TimesUsed},{qty}, {price}, {caliberId}, " +
                    $"{estCostPerItem})";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }
            return bAns;
        }

        public static bool Update(string databasePath, long id, string manufacturer, 
            string name, string ttl, bool IsNew, int TimesUsed, int qty, double price, 
            long caliberId, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int iIsNew = IsNew ? 1 : 0;
                double estCostPerItem = (price == 0) ? 0 : (price / qty);
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE List_Case set Manufacturer='{o.FC(manufacturer)}'," +
                    $"Name='{o.FC(name)}',ttl='{o.FC(ttl)}',IsNew={iIsNew}, " +
                    $"TimesUsed={TimesUsed},Qty={qty}, Price={price}, " +
                    $"CID={caliberId},eppc={estCostPerItem} where id={id}";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }
            return bAns;
        }

        public static bool Update(string databasePath, long id, int qty, double price, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                double estCostPerItem = (price == 0) ? 0 : (price / qty);
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE List_Case set Qty={qty}," +
                    $"Price={price}, eppc={estCostPerItem} where id={id}";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }
            return bAns;
        }

        public static bool Delete(string databasePath, long id, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"DELETE from List_Case where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }
            return bAns;
        }

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
