using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class Powder.  Autofill for the Powder Table
    /// </summary>
    public class Powder
    {
        /// <summary>
        /// Powders the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection PowderName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "name", "General_Powder", out errOut);
        }
    }
}
