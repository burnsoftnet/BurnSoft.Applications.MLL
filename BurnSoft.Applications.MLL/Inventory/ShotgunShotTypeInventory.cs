using BurnSoft.Applications.MLL.Enums;
using BurnSoft.Applications.MLL.Global;
using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.Inventory
{
    /// <summary>
    /// Class ShotgunShotTypeInventory handles the data in 
    /// the List_SG_ShotType_Details table
    /// </summary>
    public class ShotgunShotTypeInventory
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.ShotgunShotTypeInventory";

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
        /// <returns>List&lt;ShotgunShotTypeData&gt;.</returns>
        private static List<ShotgunShotTypeData> GetData(DataTable dt, out string errOut)
        {
            List<ShotgunShotTypeData> lst = new List<ShotgunShotTypeData>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new ShotgunShotTypeData()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Manufacturer = d["Manufacturer"] != DBNull.Value ? d["Manufacturer"].ToString().Trim() : "",
                        Name = d["Name"] != DBNull.Value ? d["Name"].ToString().Trim() : "",
                        IsSlug = Convert.ToInt32(d["IsSlug"]) == 1 ? true : false,
                        MaterialUsed = d["mat"] != DBNull.Value ? d["mat"].ToString().Trim() : "",
                        ShotNumber = d["ShotNo"] != DBNull.Value ? d["ShotNo"].ToString().Trim() : "",
                        Weight = d["weight"] != DBNull.Value ? d["weight"].ToString().Trim() : "",
                        Caliber = d["CAL"] != DBNull.Value ? d["CAL"].ToString().Trim() : "",
                        Ounces = d["ounces"] != DBNull.Value ? Convert.ToDouble(d["ounces"]) : 0,
                        Qty = d["Qty"] != DBNull.Value ? Convert.ToInt32(d["Qty"]) : 0,
                        Price = d["Price"] != DBNull.Value ? Convert.ToDouble(d["Price"]) : 0,
                        EstimatedPricePerItem = d["epps"] != DBNull.Value ? Convert.ToDouble(d["epps"]) : 0,
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
        /// <returns>List&lt;ShotgunShotTypeData&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<ShotgunShotTypeData> GetList(string databasePath, string sql, out string errOut)
        {
            List<ShotgunShotTypeData> lst = new List<ShotgunShotTypeData>();
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
        /// <returns>List&lt;ShotgunShotTypeData&gt;.</returns>
        public static List<ShotgunShotTypeData> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from List_SG_ShotType_Details order by Manufacturer,Name  ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="materialUsed">The material used.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, string manufacturer, string name, string materialUsed, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from List_SG_ShotType_Details where manufacturer='{manufacturer}' " +
                    $"and name='{name}' and mat='{materialUsed}'";
                List<ShotgunShotTypeData> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (ShotgunShotTypeData i in lst)
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
        /// <param name="materialUsed">The material used.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ShotgunShotTypeData&gt;.</returns>
        public static List<ShotgunShotTypeData> GetDetails(string databasePath, string manufacturer,
            string name, string materialUsed, out string errOut)
        {
            string sql = $"Select * from List_SG_ShotType_Details where manufacturer='{manufacturer}' " +
                $"and name='{name}' and mat='{materialUsed}'";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;ShotgunShotTypeData&gt;.</returns>
        public static List<ShotgunShotTypeData> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from List_SG_ShotType_Details where id={id}";
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
                List<ShotgunShotTypeData> lst = GetAll(databasePath, out errOut);
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
        /// <param name="materialUsed">The material used.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool DataExists(string databasePath, string manufacturer, string name, string materialUsed, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<ShotgunShotTypeData> lst = GetDetails(databasePath, manufacturer, name, materialUsed, out errOut);
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
        /// <param name="materialUsed">The material used.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="isSlug">if set to <c>true</c> [is slug].</param>
        /// <param name="shotNumber">The shot number.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string manufacturer, string name, string materialUsed,
            string weight, bool isSlug, string shotNumber, string caliber,int qty, double price, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int iSlug = isSlug ? 1 : 0;
                //double ounces = WeightValues.WEIGHT_OZ_1LBS * Convert.ToDouble(weight);
                double ounces = ConvertValueTo(weight, WeightTypes.Ounces);
                double grams = ounces * WeightValues.WEIGHT_GRAMS_OZ;
                double costPerItem = price / grams;
                string sql = $"INSERT INTO List_SG_ShotType_Details(Manufacturer,Name,IsSlug,mat," +
                    $"weight,ShotNo,CAL,Qty,Price,epps,ounces,grams,sync_lastupdate) VALUES(" +
                    $"'{manufacturer}', '{name}',{iSlug}, '{materialUsed}', " +
                    $"'{weight}','{shotNumber}','{caliber}',{qty}, {price}, " +
                    $"{costPerItem}, {ounces}, {grams}, Now())";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }
            return bAns;
        }
        /// <summary>
        /// Converts the value to for the weight types, but this might already exist. just need to 
        /// look around in the code.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="type">The type.</param>
        /// <returns>System.Double.</returns>
        public static double ConvertValueTo(string value, WeightTypes type)
        {
            double dAns = 0;
            string numericValue = value.Split(' ')[0].Trim();
            switch (type)
            {
                case WeightTypes.Ounces:
                    WeightTypes myWeight = GetWeightType(value);
                    if (myWeight == WeightTypes.Ounces)
                    {
                        dAns = Convert.ToDouble(numericValue);
                    }
                    else if( myWeight == WeightTypes.Pound)
                    {
                        dAns = WeightValues.WEIGHT_OZ_1LBS * Convert.ToDouble(numericValue);
                    }
                    break;
            }
            return dAns;
        }

        /// <summary>
        /// Gets the type of the weight base on the weight string passed where first 
        /// part is numeric and the second part is the weight type.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>WeightTypes.</returns>
        public static WeightTypes GetWeightType(string value)
        {
            string weightValue = value.Split(' ')[1].ToLower().Trim();
            switch (weightValue)
            {
                case "oz":
                case "ounces":
                case "oz.":
                    return WeightTypes.Ounces;
                case "grains":
                case "gn":
                case "gn.":
                    return WeightTypes.Grains;
                case "grams":
                case "gm.":
                case "gm":
                    return WeightTypes.Grams;
                case "lbs":
                case "lbs.":
                case "pound":
                case "pounds":
                    return WeightTypes.Pound;
                default:
                    return WeightTypes.Ounces;
            }
        }
        /// <summary>
        /// Updates the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="materialUsed">The material used.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="isSlug">if set to <c>true</c> [is slug].</param>
        /// <param name="shotNumber">The shot number.</param>
        /// <param name="caliber">The caliber details.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, long id, string manufacturer, string name, 
            string materialUsed, string weight, bool isSlug, string shotNumber, string caliber, 
            int qty, double price, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int iSlug = isSlug ? 1 : 0;
                //double ounces = WeightValues.WEIGHT_OZ_1LBS * Convert.ToDouble(weight);
                double ounces = ConvertValueTo(weight, WeightTypes.Ounces);
                double grams = ounces * WeightValues.WEIGHT_GRAMS_OZ;
                double costPerItem = price / grams;
                string sql = $"UPDATE List_SG_ShotType_Details set Manufacturer='{manufacturer}'," +
                    $"Name='{name}',mat='{materialUsed}', IsSlug={iSlug}, ShotNo='{shotNumber}', " +
                    $"weight='{weight}', CAL='{caliber}', qty={qty}, price={price}," +
                    $" epps={costPerItem}, ounces={ounces}, grams={grams}," +
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
                string sql = $"DELETE from List_SG_ShotType_Details where id={id}";
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
        /// <param name="materialUsed">The material used.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Delete(string databasePath, string manufacturer, string name, 
            string materialUsed, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                long id = GetId(databasePath, manufacturer, name, materialUsed, out errOut);
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
