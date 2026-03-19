
using BurnSoft.Applications.MLL.Inventory;

namespace BurnSoft.Applications.MLL.Global
{
    /// <summary>
    /// Class GeneralFunctions.
    /// </summary>
    public class GeneralFunctions
    {
        /// <summary>
        /// Counts the firearms.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int32.</returns>
        public static int CountFirearms(string databasePath, out string errOut)
        {
            string sql = "SELECT Count(*) as Total from Loaders_Log_Firearms where MGCID=0";
            return Database.GetCount(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Counts the ready to use ammo.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long CountReadyToUseAmmo(string databasePath, out string errOut)
        {
            string sql = "SELECT Sum(Qty) as Total from Loaders_Log_Ammunition";
            return Database.GetCount(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        public static string GetTitle(string databasePath, long id, out string errOut)
        {
            string sql = $"SELECT * from Config_List_Name where ID={id}";
            return Database.GetName(databasePath, sql, "ConfigName", out errOut);
        }
        /// <summary>
        /// Gets the ammo type identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long GetAmmoTypeID(string databasePath, string name, out string errOut)
        {
            string sql = $"SELECT ID from General_Ammunition_Type where FType='{name}'";
            return Database.GetId(databasePath, sql, out errOut);
        }
        /// <summary>
        /// Gets the ammo type idsg.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long GetAmmoTypeIDSG(string databasePath, string name, out string errOut)
        {
            string sql = $"SELECT ID from List_SG_ShotCharge_Loads where Name='{name}'";
            return Database.GetId(databasePath, sql, out errOut);
        }

        /// <summary>
        /// Gets the ammo type name shot gun.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        public static string GetAmmoTypeNameShotGun(string databasePath, long id, out string errOut)
        {
            string sql = $"SELECT Name from List_SG_ShotCharge_Loads where ID={id}";
            return Database.GetName(databasePath, sql, "Name", out errOut);
        }
        /// <summary>
        /// Gets the caliber identifier.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="name">The name.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="AutoAdd">if set to <c>true</c> [automatic add].</param>
        /// <returns>System.Int64.</returns>
        public static long GetCaliberID(string databasePath, string name, out string errOut, bool AutoAdd = false)
        {
            if (AutoAdd)
            {
                if (!CaliberInventory.DataExists(databasePath, name, out errOut))
                {
                    CaliberInventory.Add(databasePath, name, out errOut);
                }
            }
            return CaliberInventory.GetId(databasePath, name, out errOut);
        }
        /// <summary>
        /// Totals the cost equipment.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long TotalCostEquipment(string databasePath, out string errOut)
        {
            string sql = "SELECT Sum(Cost) as Total from General_Equipment";
            return Database.GetCount(databasePath, sql, out errOut);
        }
    }
}
