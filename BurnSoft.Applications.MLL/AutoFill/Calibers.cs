using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class Calibers. Auto fill for calibers list
    /// </summary>
    public class Calibers
    {
        /// <summary>
        /// Shows all.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection ShowAll(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Cal", "General_Calibers", out errOut);
        }
    }
}
