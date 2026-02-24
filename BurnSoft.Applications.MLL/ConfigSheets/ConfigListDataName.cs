using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Data;

namespace BurnSoft.Applications.MLL.ConfigSheets
{
    /// <summary>
    /// Class ConfigListDataName contains the functions to use to 
    /// interact with the data in the Config_List_Name table
    /// </summary>
    public class ConfigListDataName
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.ConfigSheets.ConfigListDataName";

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

        private static List<ConfigNameList> GetData(DataTable dt, out string errOut)
        {
            List<ConfigNameList> lst = new List<ConfigNameList>();
            errOut = "";
            try
            {
                foreach (DataRow d in dt.Rows)
                {
                    lst.Add(new ConfigNameList()
                    {
                        Id = Convert.ToInt32(d["id"]),
                        Name = d["ConfigName"] != DBNull.Value ? d["ConfigName"].ToString().Trim() : "",
                        Notes = d["Notes"] != DBNull.Value ? d["Notes"].ToString().Trim() : "",
                        IsPersonal = Convert.ToInt32(d["IsPersonal"]) == 1 ? true : false,
                        IsShotGun = Convert.ToInt32(d["IsShotGun"]) == 1 ? true : false,
                        IsActive = Convert.ToInt32(d["IsActive"]) == 1 ? true : false,
                        IsFavorite = Convert.ToInt32(d["IsFav"]) == 1 ? true : false,
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

        private static List<ConfigNameList> GetList(string databasePath, string sql, out string errOut)
        {
            List<ConfigNameList> lst = new List<ConfigNameList>();
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

        public static List<ConfigNameList> GetAll(string databasePath, out string errOut)
        {
            string sql = $"Select * from Config_List_Name order by ConfigName ASC";
            return GetList(databasePath, sql, out errOut);
        }

        public static long GetId(string databasePath, string name, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                string sql = $"Select * from Config_List_Name where ConfigName='{name}'";
                List<ConfigNameList> lst = GetList(databasePath, sql, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                foreach (ConfigNameList i in lst)
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

        public static List<ConfigNameList> GetDetails(string databasePath, string name, out string errOut)
        {
            string sql = $"Select * from Config_List_Name where ConfigName='{name}'";
            return GetList(databasePath, sql, out errOut);
        }

        public static List<ConfigNameList> GetDetails(string databasePath, long id, out string errOut)
        {
            string sql = $"Select * from Config_List_Name where id={id}";
            return GetList(databasePath, sql, out errOut);
        }
        
        public static bool DataExists(string databasePath, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {
                List<ConfigNameList> lst = GetAll(databasePath, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExists", e);
            }
            return bAns;
        }
        
        public static bool DataExists(string databasePath, string name, out string errOut)
        {
            bool bAns = false;
            errOut = @"";
            try
            {

                List<ConfigNameList> lst = GetDetails(databasePath, name, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = lst.Count > 0;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("DataExists", e);
            }
            return bAns;
        }

        
        public static bool Add(string databasePath, string name, bool isPersonal, bool isShotgun,
            string notes, bool isActive, bool isFavorite, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int iPersonal = isPersonal ? 1 : 0;
                int iShotgun = isShotgun ? 1 : 0;
                int iActive = isActive ? 1 : 0;
                int iFavorite = isFavorite ? 1 : 0;
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"INSERT INTO Config_List_Name(ConfigName,IsPersonal,IsShotGun," +
                    $"Notes,IsActive,IsFav) VALUES('{o.FC(name)}', {iPersonal}, " +
                    $"{iShotgun}, '{o.FC(notes)}', {iActive}, " +
                    $"{iFavorite})";

                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Add", e);
            }
            return bAns;
        }
        
        public static bool Update(string databasePath, long id, string name, bool isPersonal, bool isShotgun,
            string notes, bool isActive, bool isFavorite, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                int iPersonal = isPersonal ? 1 : 0;
                int iShotgun = isShotgun ? 1 : 0;
                int iActive = isActive ? 1 : 0;
                int iFavorite = isFavorite ? 1 : 0;
                BSOtherObjects o = new BSOtherObjects();
                string sql = $"UPDATE Config_List_Name set ConfigName='{o.FC(name)}'," +
                    $"IsPersonal={iPersonal},IsShotGun={iShotgun},Notes='{o.FC(notes)}'," +
                    $"IsActive={iActive},IsFav={iFavorite} where id={id}";

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
                string sql = $"DELETE from Config_List_Name where id={id}";
                bAns = Database.Execute(databasePath, sql, out errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Delete", e);
            }
            return bAns;
        }
        
        public static bool Delete(string databasePath, string name, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                long id = GetId(databasePath, name, out errOut);
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
