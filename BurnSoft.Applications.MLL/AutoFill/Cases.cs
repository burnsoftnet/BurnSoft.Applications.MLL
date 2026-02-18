using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class Cases.Autofill for the Cases Table
    /// </summary>
    public class Cases
    {
        /// <summary>
        /// Powders the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Name(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Name", "List_Case", out errOut);
        }
        /// <summary>
        /// Manufacturers the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Manufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_Case", out errOut);
        }
        /// <summary>
        /// Prices the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Price(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Price", "List_Case", out errOut);
        }
        /// <summary>
        /// Diameters the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TrimToLength(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "ttl", "List_Case", out errOut);
        }
    }
}
