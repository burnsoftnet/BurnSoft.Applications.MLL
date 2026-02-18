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
        /// <summary>
        /// Lengthes the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Length(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Length", "List_SG_Case", out errOut);
        }
        /// <summary>
        /// Prices the specified database path.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection Price(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Price", "List_SG_Case", out errOut);
        }
        /// <summary>
        /// Types the details manufacturer.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TypeDetailsManufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_SG_ShotType_Details", out errOut);
        }
        /// <summary>
        /// Types the name of the details.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TypeDetailsName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Name", "List_SG_ShotType_Details", out errOut);
        }
        /// <summary>
        /// Types the details mat.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TypeDetailsMat(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "mat", "List_SG_ShotType_Details", out errOut);
        }
        /// <summary>
        /// Types the details shot no.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TypeDetailsShotNo(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "ShotNo", "List_SG_ShotType_Details", out errOut);
        }
        /// <summary>
        /// Types the details weight.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TypeDetailsWeight(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "weight", "List_SG_ShotType_Details", out errOut);
        }
        /// <summary>
        /// Types the details caliber.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TypeDetailsCaliber(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "CAL", "List_SG_ShotType_Details", out errOut);
        }
        /// <summary>
        /// Types the details price.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>AutoCompleteStringCollection.</returns>
        public static AutoCompleteStringCollection TypeDetailsPrice(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Price", "List_SG_ShotType_Details", out errOut);
        }
    }
}
