using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class GeneralShotgun.General Shotgun Autofill Options
    /// </summary>
    public class GeneralShotgun
    {
        /// <summary>
        /// Cases the manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection CaseManufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_SG_Case", out errOut);
        }
        /// <summary>
        /// Cases the name.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection CaseName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Name", "List_SG_Case", out errOut);
        }
        /// <summary>
        /// Drams the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Dram(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "DRAM", "List_SG_Case", out errOut);
        }
        /// <summary>
        /// Gauges the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Gauge(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Gauge", "List_SG_Case", out errOut);
        }
    }
}
