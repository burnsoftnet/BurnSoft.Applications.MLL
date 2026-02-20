using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class Equipment. Autofill for the Equipment Table
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// Powders the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Name(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Name", "General_Equipment", out errOut);
        }
        /// <summary>
        /// Manufacturers the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Manufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "General_Equipment", out errOut);
        }
        /// <summary>
        /// Prices the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Cost(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Cost", "General_Equipment", out errOut);
        }
        /// <summary>
        /// Diameters the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Use(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Use", "General_Equipment", out errOut);
        }
    }
}
