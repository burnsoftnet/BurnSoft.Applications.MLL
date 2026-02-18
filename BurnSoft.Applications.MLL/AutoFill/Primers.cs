using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class Primers. Autofill for the Primers Table
    /// </summary>
    public class Primers
    {
        /// <summary>
        /// Powders the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Name(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "name", "General_Primer", out errOut);
        }
        /// <summary>
        /// Manufacturers the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Manufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "General_Primer", out errOut);
        }
        /// <summary>
        /// Prices the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Price(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Price", "General_Primer", out errOut);
        }
    }
}
