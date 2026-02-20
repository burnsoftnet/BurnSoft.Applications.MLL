using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class Bullets. Autofill for the Bullets Table
    /// </summary>
    public class Bullets
    {
        /// <summary>
        /// Powders the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Name(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Name", "List_Bullets", out errOut);
        }
        /// <summary>
        /// Manufacturers the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Manufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_Bullets", out errOut);
        }
        /// <summary>
        /// Prices the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Price(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Price", "List_Bullets", out errOut);
        }
        /// <summary>
        /// Diameters the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Diameter(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Diameter", "List_Bullets", out errOut);
        }
        /// <summary>
        /// Sectionals the density.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection SectionalDensity(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Sec_Den", "List_Bullets", out errOut);
        }
        /// <summary>
        /// Parts the number.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection PartNumber(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Part_number", "List_Bullets", out errOut);
        }
        /// <summary>
        /// Ballistics the coefficient.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection BallisticCoefficient(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Ballistic_Coefficient", "List_Bullets", out errOut);
        }
        /// <summary>
        /// Weights the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Weight(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Weight", "List_Bullets", out errOut);
        }
    }
}
