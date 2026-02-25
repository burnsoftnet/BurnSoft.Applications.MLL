using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class ConfigMetalic. Auto fill for the config and Loaders log
    /// </summary>
    public class ConfigMetalic
    {
        /// <summary>
        /// Configurations the name of the list.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection ConfigListName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "ConfigName", "Config_List_Name", out errOut);
        }
        /// <summary>
        /// Sources the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Source(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Source", "Config_List_Data_NSG", out errOut);
        }
        /// <summary>
        /// Groupings the specified database path. group size
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection GroupSize(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "gs", "Loaders_Log_NSG", out errOut);
        }
        /// <summary>
        /// Powders the weight. powder - wt. - mfg
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection PowderWeight(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "pwm", "Loaders_Log_NSG", out errOut);
        }
        /// <summary>
        /// Bullets the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Bullet(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "bullet", "Loaders_Log_NSG", out errOut);
        }
        /// <summary>
        /// Primers the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Primer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "primer", "Loaders_Log_NSG", out errOut);
        }
        /// <summary>
        /// Cases the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Case(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "case", "Loaders_Log_NSG", out errOut);
        }
        /// <summary>
        /// Conditionses the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Conditions(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "conditions", "Loaders_Log_NSG", out errOut);
        }
        /// <summary>
        /// Totals the lenght.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TotalLenght(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "tl", "Loaders_Log_NSG", out errOut);
        }
        /// <summary>
        /// Noteses the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Notes(string databasePath, out string errOut)
        {
            return General.MainCollectionND(databasePath, "notes", "Loaders_Log_NSG", out errOut);
        }
        /// <summary>
        /// Configurations the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection ConfigName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "ConfigName", "Loaders_Log_NSG", out errOut);
        }
    }
}
