using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.Inventory
{
    /// <summary>
    /// Class Bullets handles the ability to interact with the List_Bullets Table
    /// </summary>
    public class BulletsInventory
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.Bullets";

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
        /// <returns>List&lt;BulletListings&gt;.</returns>
        private static List<BulletListings> GetData(DataTable dt, out string errOut)
        {
            List<BulletListings> lst = new List<BulletListings>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new BulletListings()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Manufacturer = d["Manufacturer"] != DBNull.Value ? d["Manufacturer"].ToString().Trim() : "",
                        Name = d["Name"] != DBNull.Value ? d["Name"].ToString().Trim() : "",
                        Diameter = d["Diameter"] != DBNull.Value ? d["Diameter"].ToString().Trim() : "",
                        Weight = d["Weight"] != DBNull.Value ? d["Weight"].ToString().Trim() : "",
                        SectionDensity = d["Sec_Den"] != DBNull.Value ? d["Sec_Den"].ToString().Trim() : "",
                        PartNumber = d["Part_number"] != DBNull.Value ? d["Part_number"].ToString().Trim() : "",
                        BallisticCoeffcient = d["Ballistic_Coefficient"] != DBNull.Value ? d["Ballistic_Coefficient"].ToString().Trim() : "",
                        BullerType = Convert.ToInt32(d["Bullet_Type"]),
                        Qty = Convert.ToInt32(d["Qty"]),
                        Price = Convert.ToDouble(d["Price"]),
                        CaliberId = Convert.ToInt32(d["CID"]),
                        EsitmatedPricePerBullet = Convert.ToDouble(d["ePPB"]),
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
        /// <returns>List&lt;BulletListings&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<BulletListings> GetList(string databasePath, string sql, out string errOut)
        {
            List<BulletListings> lst = new List<BulletListings>();
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
        /// <returns>List&lt;BulletListings&gt;.</returns>
        public static List<BulletListings> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from List_Bullets order by Manufacturer,Name  ASC";
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
                string sql = $"Select * from List_Bullets where manufacturer='{manufacturer}' and name='{name}'";
                List<BulletListings> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (BulletListings i in lst)
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
        /// <returns>List&lt;BulletListings&gt;.</returns>
        public static List<BulletListings> GetDetails(string databasePath, string manufacturer, string name, out string errOut)
        {
            string sql = $"Select * from List_Bullets where manufacturer='{manufacturer}' and name='{name}'";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;BulletListings&gt;.</returns>
        public static List<BulletListings> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from List_Bullets where id={id}";
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
                List<BulletListings> lst = GetAll(databasePath, out errOut);
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

                List<BulletListings> lst = GetDetails(databasePath, manufacturer, name, out errOut);
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
        /// Adds The new bullet information to the database
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="name">The name.</param>
        /// <param name="diameter">The diameter.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="sectionalDensity">The sectional density.</param>
        /// <param name="partNumber">The part number.</param>
        /// <param name="bc">The bc.</param>
        /// <param name="bulletType">Type of the bullet.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="caliberId">The caliber identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string manufacturer, string name, string diameter,
            string weight, string sectionalDensity, string partNumber, string bc, int bulletType, 
            int qty, double price, long caliberId,  out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                double estCostPerBullet = (price == 0) ? 0 : (price/qty);
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"INSERT INTO List_Bullets(Manufacturer,Name,Diameter," +
                    $"Weight,Sec_Den,Part_number,Ballistic_Coefficient,Bullet_Type,Qty," +
                    $"Price,CID,eppb) VALUES('{o.FC(manufacturer)}', '{o.FC(name)}', " +
                    $"'{o.FC(diameter)}', '{o.FC(weight)}', '{o.FC(sectionalDensity)}', " +
                    $"'{o.FC(partNumber)}', '{o.FC(bc)}', {bulletType}, {qty}, " +
                    $"{price}, {caliberId}, {estCostPerBullet})";

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
        /// <param name="diameter">The diameter.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="sectionalDensity">The sectional density.</param>
        /// <param name="partNumber">The part number.</param>
        /// <param name="bc">The bc.</param>
        /// <param name="bulletType">Type of the bullet.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="price">The price.</param>
        /// <param name="caliberId">The caliber identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath,long id, string manufacturer, string name, string diameter,
            string weight, string sectionalDensity, string partNumber, string bc, int bulletType,
            int qty, double price, long caliberId, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                double estCostPerBullet = (price == 0) ? 0 : (price / qty);
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE List_Bullets set Manufacturer='{o.FC(manufacturer)}'," +
                    $"Name='{o.FC(name)}',Diameter='{o.FC(diameter)}',Weight='{o.FC(weight)}'," +
                    $"Sec_Den='{o.FC(sectionalDensity)}',Part_number='{o.FC(partNumber)}'," +
                    $"Ballistic_Coefficient='{o.FC(bc)}',Bullet_Type={bulletType},Qty={qty}," +
                    $"Price={price},CID={caliberId},eppb={estCostPerBullet} where id={id}";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Update", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the BUllet information when you just jabe to update the price and qty which 
        /// will adjust the estimated price per bullet.
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
                double estCostPerBullet = (price == 0) ? 0 : (price / qty);
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE List_Bullets set Qty={qty}," +
                    $"Price={price}, eppb={estCostPerBullet} where id={id}";

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
                string sql = $"DELETE from List_Bullets where id={id}";
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
