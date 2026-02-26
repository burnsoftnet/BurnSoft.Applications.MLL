using BurnSoft.Applications.MLL.Global;
using BurnSoft.Applications.MLL.Helpers;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace BurnSoft.Applications.MLL.Inventory
{
    /// <summary>
    /// Class PowderInventory to work with the data in the General_Powder Table.
    /// </summary>
    public class PowderInventory
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.PowderInventory";

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
        
        private static List<PowderListing> GetData(DataTable dt, out string errOut)
        {
            List<PowderListing> lst = new List<PowderListing>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new PowderListing()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Manufacturer = d["Manufacturer"] != DBNull.Value ? d["Manufacturer"].ToString().Trim() : "",
                        Name = d["Name"] != DBNull.Value ? d["Name"].ToString().Trim() : "",
                        WeightInPounds = Convert.ToDouble(d["weightlbs"]),
                        WeightInGrains = Convert.ToDouble(d["weightgn"]),
                        Price = Convert.ToDouble(d["Price"]),
                        Notes = d["Notes"] != DBNull.Value ? d["Notes"].ToString().Trim() : "",
                        PricePerGrain = Convert.ToDouble(d["ePPP"]),
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
        
        private static List<PowderListing> GetList(string databasePath, string sql, out string errOut)
        {
            List<PowderListing> lst = new List<PowderListing>();
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
        
        public static List<PowderListing> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from General_Powder order by Manufacturer,Name  ASC";
            return GetList(databasePath, sql, out errOut);
        }
        
        public static long GetId(string databasePath, string manufacturer, string name, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from General_Powder where manufacturer='{manufacturer}' and name='{name}'";
                List<PowderListing> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (PowderListing i in lst)
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
        
        public static List<PowderListing> GetDetails(string databasePath, string manufacturer, string name, out string errOut)
        {
            string sql = $"Select * from General_Powder where manufacturer='{manufacturer}' and name='{name}'";
            return GetList(databasePath, sql, out errOut);
        }
        
        public static List<PowderListing> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from General_Powder where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
        
        public static bool DataExists(string databasePath, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                List<PowderListing> lst = GetAll(databasePath, out errOut);
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

                List<PowderListing> lst = GetDetails(databasePath, manufacturer, name, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExists", e);
            }
            return bAns;
        }
        
        public static bool Add(string databasePath, string manufacturer, string name, double weightInPounds,
            double price, string notes, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                double weightInGrains = Converters.ConvertWeight(weightInPounds, WeightValues.WeightType.Grains, 
                    WeightValues.WeightType.Pounds, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                double PricePerGrain = (price/weightInGrains);
                string sql = $"INSERT INTO General_Powder(Manufacturer,Name,weightlbs," +
                    $"weightgn,Price,Notes,ePPP, sync_lastupdate) VALUES(" +
                    $"'{o.FC(manufacturer)}', '{o.FC(name)}', {weightInPounds}, " +
                    $"{weightInGrains}, {price}, '{o.FC(notes)}', {PricePerGrain},Now())";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }
            return bAns;
        }
     
        public static bool Update(string databasePath, long id, string manufacturer, string name, 
            double weightInPounds, double price, string notes, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                double weightInGrains = Converters.ConvertWeight(weightInPounds, WeightValues.WeightType.Grains,
                    WeightValues.WeightType.Pounds, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                double PricePerGrain = (price / weightInGrains);
                string sql = $"UPDATE General_Powder set Manufacturer='{o.FC(manufacturer)}'," +
                    $"Name='{o.FC(name)}',weightlbs={weightInPounds},weightgn={weightInGrains},Price={price}," +
                    $"Notes='{o.FC(notes)}',ePPP={PricePerGrain}, sync_lastupdate=Now() where id={id}";

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
                string sql = $"DELETE from General_Powder where id={id}";
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
