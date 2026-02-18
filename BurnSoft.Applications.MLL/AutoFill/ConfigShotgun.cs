using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class ConfigShotgun.  Auto fill for the configuration and loaders log for the shotgun section
    /// </summary>
    public class ConfigShotgun
    {
        /// <summary>
        /// Sources the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Source(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Source", "Config_List_Data_SG", out errOut);
        }
        /// <summary>
        /// Loads the in ounces.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection LoadInOunces(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "SW_t", "Config_List_Data_SG", out errOut);
        }
        /// <summary>
        /// Wads the manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection WadManufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_SG_WAD", out errOut);
        }
        /// <summary>
        /// Wadses the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Wads(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "WAD", "List_SG_WAD", out errOut);
        }
        /// <summary>
        /// Wads the price.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection WadPrice(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Price", "List_SG_WAD", out errOut);
        }
        /// <summary>
        /// Bushings the powder manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection BushingPowderManufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_SG_Bushing_Powder", out errOut);
        }
        /// <summary>
        /// Bushings the name of the powder.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection BushingPowderName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "sName", "List_SG_Bushing_Powder", out errOut);
        }
        
        /// <summary>
        /// Bushings the shot manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection BushingShotManufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_SG_Bushing_Shot", out errOut);
        }
        /// <summary>
        /// Bushings the name of the shot.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection BushingShotName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "sName", "List_SG_Bushing_Shot", out errOut);
        }
        /// <summary>
        /// Bushings the shot charge.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection BushingShotCharge(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "sCharge", "List_SG_Bushing_Shot", out errOut);
        }
        /// <summary>
        /// Logs the pattern.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection LogPattern(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "pd", "Loaders_Log_SG", out errOut);
        }
        /// <summary>
        /// Logs the shot weight.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection LogShotWeight(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "shotwt", "Loaders_Log_SG", out errOut);
        }
        /// <summary>
        /// Logs the size of the shot.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection LogShotSize(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "shotsize", "Loaders_Log_SG", out errOut);
        }
        /// <summary>
        /// Logs the case.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection LogCase(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "case", "Loaders_Log_SG", out errOut);
        }
        /// <summary>
        /// Logs the powder bushing.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection LogPowderBushing(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "pbm", "Loaders_Log_SG", out errOut);
        }
        /// <summary>
        /// Logs the wad.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection LogWad(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "wad", "Loaders_Log_SG", out errOut);
        }
        /// <summary>
        /// Logs the primer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection LogPrimer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "primer", "Loaders_Log_SG", out errOut);
        }
    }
}
