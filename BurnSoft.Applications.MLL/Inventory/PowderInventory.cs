using BurnSoft.Applications.MLL.Enums;
using BurnSoft.Applications.MLL.Global;
using BurnSoft.Applications.MLL.Helpers;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;

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
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PowderListing&gt;.</returns>
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
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PowderListing&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
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
                errOut = $"{errOut}{Environment.NewLine}SQL: {sql}";
            }
            return lst;
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PowderListing&gt;.</returns>
        public static List<PowderListing> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from General_Powder order by Manufacturer,Name  ASC";
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
        /// <summary>
        /// Gets the qty per powder using the weight in grains
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.Exception"></exception>
        public static double GetQtyPerPowder(string databasePath, long id, out string errOut)
        {
            errOut = "";
            double dAns = 0;
            try
            {
                string sql = $"Select * from General_Powder where id={id}";
                List<PowderListing> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (PowderListing i in lst)
                {
                    dAns = i.WeightInGrains;
                    break;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetQtyPerPowder", e);
            }
            return dAns;
        }
        /// <summary>
        /// Gets the price per powder.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Double.</returns>
        /// <exception cref="System.Exception"></exception>
        public static double GetPricePerPowder(string databasePath, long id, out string errOut)
        {
            errOut = "";
            double dAns = 0;
            try
            {
                string sql = $"Select * from General_Powder where id={id}";
                List<PowderListing> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (PowderListing i in lst)
                {
                    dAns = i.PricePerGrain;
                    break;
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetPricePerPowder", e);
            }
            return dAns;
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PowderListing&gt;.</returns>
        public static List<PowderListing> GetDetails(string databasePath, string manufacturer, string name, out string errOut)
        {
            string sql = $"Select * from General_Powder where manufacturer='{manufacturer}' and name='{name}'";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;PowderListing&gt;.</returns>
        public static List<PowderListing> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from General_Powder where id={id}";
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
        /// <summary>
        /// Adds the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="weightInPounds">The weight in pounds.</param>
        /// <param name="price">The price.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Add(string databasePath, string manufacturer, string name, double weightInPounds,
            double price, string notes, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                manufacturer = o.FC(manufacturer);
                name = o.FC(name);
                notes = o.FC(notes);

                double weightInGrains = Converters.ConvertWeight(weightInPounds, WeightValues.WeightType.Grains, 
                    WeightValues.WeightType.Pounds, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                double PricePerGrain = (price/weightInGrains);
                string sql = $"INSERT INTO General_Powder(Manufacturer,Name,weightlbs," +
                    $"weightgn,Price,Notes,ePPP, sync_lastupdate) VALUES(" +
                    $"'{manufacturer}', '{name}', {weightInPounds}, " +
                    $"{weightInGrains}, {price}, '{notes}', {PricePerGrain},Now())";

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
        /// <param name="weightInPounds">The weight in pounds.</param>
        /// <param name="price">The price.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
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
                    $"Notes='{o.FC(notes, "  ")}',ePPP={PricePerGrain}, sync_lastupdate=Now() where id={id}";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }
            return bAns;
        }
        /// <summary>
        /// Drops down to enum.
        /// </summary>
        /// <param name="value">The value. ( Grains (grs) or Pounds (lbs) )</param>
        /// <returns>PowderWeightType.</returns>
        public static PowderWeightType DropDownToEnum(string value)
        {
            switch(value.ToLower())
            {
                case "grains (grs)":
                    return PowderWeightType.Grains;
                case "pounds (lbs)":
                    return PowderWeightType.Pounds;
                default:
                    return PowderWeightType.Pounds;
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
        /// <param name="NewPrice">Creates new price.</param>
        /// <param name="weightType">Type of the weight.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool UpdateQty(string databasePath, long id, int currentQty, double currentPrice,
            double currentPricePerItem, int newQty, double NewPrice, PowderWeightType weightType, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int qty = currentQty + newQty;
                double price = (currentQty * currentPricePerItem) + NewPrice;
                double estCostPerItem = Converters.ConvertToDollars((price == 0) ? 0 : (price / qty));
                double newGrains = 0;
                double newPounds = 0;

                switch (weightType)
                {
                    case PowderWeightType.Pounds:
                        newPounds = newQty;
                        newGrains = Converters.ConvertWeight(newQty, WeightValues.WeightType.Grains, WeightValues.WeightType.Pounds, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        estCostPerItem = Converters.ConvertToDollars((price == 0) ? 0 : (price / (qty * WeightValues.WEIGHT_GRAINS_1LBS)));
                        break;
                    case PowderWeightType.Grains:
                        newGrains = newQty;
                        newPounds = Converters.ConvertWeight(newQty, WeightValues.WeightType.Pounds, WeightValues.WeightType.Grains, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        estCostPerItem = Converters.ConvertToDollars((price == 0) ? 0 : (price / qty));
                        break;
                }

                string sql = $"UPDATE General_Powder set weightlbs={newPounds}, weightgn={newGrains}, " +
                    $"Price={price}, ePPP={estCostPerItem} where id={id}";

                if (currentPricePerItem == estCostPerItem)
                {
                    sql = $"UPDATE General_Powder set weightlbs={newPounds}, weightgn={newGrains}, " +
                    $"Price={NewPrice} where id={id}";
                }
                else if (NewPrice == 0 && newQty == 0)
                {
                    sql = $"UPDATE General_Powder set weightlbs=0, weightgn=0, Price=0, ePPP=0 where id={id}";
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
        /// <param name="newPounds">The new pounds.</param>
        /// <param name="newGrains">The new grains.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool UpdateQty(string databasePath, long id, double newPounds, double newGrains, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string sql = $"UPDATE General_Powder set  weightlbs={newPounds}, weightgn={newGrains} where id={id}";
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
                string sql = $"DELETE from General_Powder where id={id}";
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
        /// <param name="weightValue">The weight value.</param>
        /// <param name="price">The  price.</param>
        /// <param name="VolumeType">Type of the of weight: Grains (grs) , Pounds (lbs).</param>
        /// <param name="useDollar"> Use the Dollar amount to get the doube with 2 decimal places, 
        /// when set to false it will give you the full double.</param>
        /// <returns>System.Double.</returns>
        public static double CalculatePricePerItem(double weightValue, double price, PowderWeightType VolumeType, 
            bool useDollar = false)
        {
            double dAns = 0;
            double lNewValue = 0;
            switch (VolumeType)
            {
                case PowderWeightType.Grains:
                    {
                        lNewValue = weightValue;
                        break;
                    }

                case PowderWeightType.Pounds:
                    {
                        lNewValue = weightValue * WeightValues.WEIGHT_GRAINS_1LBS;
                        break;
                    }
            }
            if (weightValue > 0)
                dAns = price / lNewValue;

            if (useDollar)
            {
                return Converters.ConvertToDollars(dAns);
            } else
            {
                return dAns;
            }
        }
        /// <summary>
        /// Updates the qty and price per item using the current qty in inventory and adding the new item details in stock
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="currentQty">The current qy.</param>
        /// <param name="currentGrains">The current grains.</param>
        /// <param name="currentPrice">The current price.</param>
        /// <param name="currentPricePerItem">The current price per item.</param>
        /// <param name="newQty">The new qty.</param>
        /// <param name="newPrice">The new price.</param>
        /// <param name="VolumeType">Type of the volume.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool UpdateQty(string databasePath, long id, double currentQty, double currentGrains, double currentPrice, 
            double currentPricePerItem, double newQty, double newPrice, PowderWeightType VolumeType, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                double updatedPricePerItem = CalculatePricePerItem(newQty, newPrice, VolumeType);
                double updatedGrains = 0;
                double updatedPounds = 0;
                switch (VolumeType)
                {
                    case PowderWeightType.Pounds:
                        updatedPounds = newQty;
                        updatedGrains = Converters.ConvertWeight(newQty, WeightValues.WeightType.Grains, 
                            WeightValues.WeightType.Pounds, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        break;
                    case PowderWeightType.Grains:
                        updatedGrains = newQty;
                        updatedPounds = Converters.ConvertWeight(newQty, WeightValues.WeightType.Pounds, 
                            WeightValues.WeightType.Grains, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        break;
                }
                double newGrains = currentGrains + updatedGrains;
                double newPounds = currentQty + updatedPounds;
                double UpdatedPrice = (currentGrains * currentPricePerItem) + newPrice;
                double newPricePerItem = UpdatedPrice / newGrains;
                string sql = "";
                if (currentPricePerItem == updatedPricePerItem)
                {
                    sql = $"UPDATE General_Powder set weightlbs={newPounds}, weightgn={newGrains}, " +
                        $"Price={newPrice} where ID={id}";
                } else if ((UpdatedPrice == 0) && (currentQty == 0))
                {
                    sql = $"UPDATE General_Powder set weightlbs=0,weightgn=0, Price=0, eppp=0 where ID={id}";
                }
                else
                {
                    sql = $"UPDATE General_Powder set weightlbs={newPounds}, weightgn={newGrains}, Price={newPrice}," +
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
