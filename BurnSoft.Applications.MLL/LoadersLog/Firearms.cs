using BurnSoft.Applications.MLL.Types;
using BurnSoft.Security.RegularEncryption.SHA;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.Applications.MLL.LoadersLog
{
    /// <summary>
    /// Class Firearms which handles the local collection for 
    /// the loaders log firearms that is used
    /// </summary>
    public class Firearms
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.LoadersLog.Firearms";

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
        /// Gets the data from the data table and puts it in for the 
        /// FirearmCollection list container
        /// </summary>
        /// <param name="dt">The dt.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;FirearmCollection&gt;.</returns>
        private static List<FirearmCollection> GetData(DataTable dt, out string errOut)
        {
            List<FirearmCollection> lst = new List<FirearmCollection>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new FirearmCollection()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        MyGunCollectionId = Convert.ToInt32(d["MGCID"]),
                        FullName = d["FullName"] != DBNull.Value ? d["FullName"].ToString().Trim() : "",
                        Manufacturer = d["Manu"] != DBNull.Value ? d["Manu"].ToString().Trim() : "",
                        Model = d["Model"] != DBNull.Value ? d["Model"].ToString().Trim() : "",
                        Caliber = d["Cal"] != DBNull.Value ? d["Cal"].ToString().Trim() : "",
                        Barrel = d["Barrel"] != DBNull.Value ? d["Barrel"].ToString().Trim() : "",
                        SerialNo = d["SerialNo"] != DBNull.Value ? d["SerialNo"].ToString().Trim() : "",
                        GunType = d["GType"] != DBNull.Value ? d["GType"].ToString().Trim() : "",
                        Exclude = Convert.ToInt32(d["Exclude"]) == 1,
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
        /// Gets the details of the selected firearm
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;FirearmCollection&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        public static List<FirearmCollection> GetDetails(string databasePath, int id, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_Firearms where ID={id}";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;FirearmCollection&gt;.</returns>
        public static List<FirearmCollection> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from Loaders_Log_Firearms order by FullName ASC";
            return GetList(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="sql">The SQL.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;FirearmCollection&gt;.</returns>
        /// <exception cref="System.Exception"></exception>
        private static List<FirearmCollection> GetList(string databasePath, string sql, out string errOut)
        {
            List<FirearmCollection> lst = new List<FirearmCollection>();
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

        /// <summary>
        /// Gets the firearm identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="fullName">The full name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        /// <exception cref="System.Exception"></exception>
        public static long GetId(string databasePath, string fullName, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from Loaders_Log_Firearms where fullname='{fullName}'";
                List<FirearmCollection> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (FirearmCollection i in lst)
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
        /// Adds the firearm to the loaders log table to use for sample logging testing.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="model">The model.</param>
        /// <param name="serial">The serial.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="type">The type.</param>
        /// <param name="barrel">The barrel.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="mgcId">The MGC identifier.</param>
        /// <param name="exclude">if set to <c>true</c> [exclude].</param>
        /// <param name="fullName">The full name.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Add(string databasePath, string manufacturer, string model, string serial, 
            string caliber, string type, string barrel,  out string errOut, int mgcId = 0, 
            bool exclude = false, string fullName = "")
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                fullName = fullName.Length == 0 ? $"{manufacturer} {model}" : fullName;
                int iExclude = exclude ? 0 : 1;
                string sql = $"INSERT INTO Loaders_Log_Firearms (MGCID,FullName,Manu,Model,Cal,Barrel,SerialNo," +
                    $"GType,exclude) VALUES({mgcId},'{o.FC(fullName)}', '{o.FC(manufacturer)}', '{o.FC(model)}', " +
                    $"'{o.FC(caliber)}', '{o.FC(barrel)}', '{o.FC(serial)}', '{o.FC(type)}', {iExclude})";

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
        /// <param name="serial">The serial.</param>
        /// <param name="caliber">The caliber.</param>
        /// <param name="type">The type.</param>
        /// <param name="barrel">The barrel.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="mgcId">The MGC identifier.</param>
        /// <param name="exclude">if set to <c>true</c> [exclude].</param>
        /// <param name="fullName">The full name.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool Update(string databasePath, int id, string manufacturer, string model, string serial,
            string caliber, string type, string barrel, out string errOut, int mgcId = 0,
            bool exclude = false, string fullName = "")
        {
            errOut = "";
            bool bAns = false;
            try
            {
                BSOtherObjects o = new BSOtherObjects();
                fullName = fullName.Length == 0 ? $"{manufacturer} {model}" : fullName;
                int iExclude = exclude ? 0 : 1;
                string sql = $"UPDATE Loaders_Log_Firearms set MGCID={mgcId}," +
                    $"FullName='{o.FC(fullName)}',Manu='{o.FC(manufacturer)}'," +
                    $"Model='{o.FC(model)}',Cal='{o.FC(caliber)}',Barrel='{o.FC(barrel)}'," +
                    $"SerialNo='{o.FC(serial)}',GType='{o.FC(type)}',exclude={iExclude} where id={id}";

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
                string sql = $"DELETE from Loaders_Log_Firearms where id={id}";
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
        /// <param name="fullName">The full name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool Delete(string databasePath, string fullName, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                long id = GetId(databasePath, fullName, out errOut);
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
