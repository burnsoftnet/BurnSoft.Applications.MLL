using System.Windows.Forms;

namespace BurnSoft.Applications.MLL.AutoFill
{
    /// <summary>
    /// Class ConfigShotgun.  Auto fill for the configuration shotgun section
    /// </summary>
    public class ConfigShotgun
    {
        public static AutoCompleteStringCollection Source(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Source", "Config_List_Data_SG", out errOut);
        }

        public static AutoCompleteStringCollection LoadInOunces(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "SW_t", "Config_List_Data_SG", out errOut);
        }

        public static AutoCompleteStringCollection WadManufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_SG_WAD", out errOut);
        }

        public static AutoCompleteStringCollection Wads(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "WAD", "List_SG_WAD", out errOut);
        }

        public static AutoCompleteStringCollection WadPrice(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Price", "List_SG_WAD", out errOut);
        }

        public static AutoCompleteStringCollection BushingPowderManufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_SG_Bushing_Powder", out errOut);
        }

        public static AutoCompleteStringCollection BushingPowderName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "sName", "List_SG_Bushing_Powder", out errOut);
        }

        public static AutoCompleteStringCollection PowderName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "name", "General_Powder", out errOut);
        }

        public static AutoCompleteStringCollection BushingShotManufacturer(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "Manufacturer", "List_SG_Bushing_Shot", out errOut);
        }

        public static AutoCompleteStringCollection BushingShotName(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "sName", "List_SG_Bushing_Shot", out errOut);
        }
        public static AutoCompleteStringCollection BushingShotCharge(string databasePath, out string errOut)
        {
            return General.MainCollection(databasePath, "sCharge", "List_SG_Bushing_Shot", out errOut);
        }
    }
}
