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
            }
            return lst;
        }
        
        public static List<PrimerListings> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from General_Primer order by Manufacturer,Name  ASC";
            return GetList(databasePath, sql, out errOut);
        }
        
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
        
        public static List<PrimerListings> GetDetails(string databasePath, string manufacturer, string name, out string errOut)
        {
            string sql = $"Select * from General_Primer where manufacturer='{manufacturer}' and name='{name}'";
            return GetList(databasePath, sql, out errOut);
        }
        
        public static List<PrimerListings> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from General_Primer where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
        
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
                double PricePerGrain = (price / weightInGrains);
                string sql = $"INSERT INTO General_Primer(Manufacturer,Name,weightlbs," +
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
                string sql = $"UPDATE General_Primer set Manufacturer='{o.FC(manufacturer)}'," +
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
            }
            else
            {
                return dAns;
            }
        }
        
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
                    sql = $"UPDATE General_Primer set weightlbs={newPounds}, weightgn={newGrains}, " +
                        $"Price={newPrice} where ID={id}";
                }
                else if ((UpdatedPrice == 0) && (currentQty == 0))
                {
                    sql = $"UPDATE General_Primer set weightlbs=0,weightgn=0, Price=0, eppp=0 where ID={id}";
                }
                else
                {
                    sql = $"UPDATE General_Primer set weightlbs={newPounds}, weightgn={newGrains}, Price={newPrice}," +
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
