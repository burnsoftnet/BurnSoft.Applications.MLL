using BurnSoft.Applications.MLL.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.Applications.MLL.Inventory
{
    /// <summary>
    /// Class InventoryUpdate does just that functions ot update the 
    /// inventory when you make some ammo
    /// </summary>
    public class InventoryUpdate
    {
        #region "Exception Error Handling"

        /// <summary>
        /// The class location
        /// </summary>
        private static string ClassLocation = "BurnSoft.Applications.MLL.Inventory.InventoryUpdate";

        /// <summary>
        /// Errors the message for regular Exceptions
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, Exception e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for access violations
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, AccessViolationException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for invalid cast exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, InvalidCastException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message argument exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        /// <summary>
        /// Errors the message for argument null exception.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentNullException e) =>
            $"{ClassLocation}.{functionName} - {e.Message}";

        #endregion            
        /// <summary>
        /// Metallics the update qty for items used in make laoded ammuniation process
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="qtyMade">The qty made.</param>
        /// <param name="bulletsInStockQty">The bullets in stock qty.</param>
        /// <param name="bulletId">The bullet identifier.</param>
        /// <param name="primersInStockQty">The primers in stock qty.</param>
        /// <param name="primerId">The primer identifier.</param>
        /// <param name="caseInStockQty">The case in stock qty.</param>
        /// <param name="caseId">The case identifier.</param>
        /// <param name="powderInStockGrains">The powder in stock grains.</param>
        /// <param name="perfferedPowderId">The perffered powder identifier.</param>
        /// <param name="midRangePowderUsed">The mid range powder used.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool MetallicUpdate(string databasePath, long qtyMade, long bulletsInStockQty, long bulletId, 
            long primersInStockQty, long primerId, long caseInStockQty, long caseId, double powderInStockGrains, 
            long perfferedPowderId, double midRangePowderUsed, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                long newBulletQty = bulletsInStockQty - qtyMade;
                long newPrimer = primersInStockQty - qtyMade;
                long newCase = caseInStockQty - qtyMade;
                double newPowderGrains = powderInStockGrains - (midRangePowderUsed * qtyMade);
                double newPowderPounds = Math.Round(newPowderGrains / WeightValues.WEIGHT_GRAINS_1LBS, 3);

                if (!BulletsInventory.UpdateQty(databasePath, bulletId, newBulletQty, out errOut)) throw new Exception(errOut);
                if (!PrimerInventory.UpdateQty(databasePath, primerId, newPrimer, out errOut)) throw new Exception(errOut);
                if (!CaseInventory.UpdateQty(databasePath, caseId, newCase, out errOut)) throw new Exception(errOut);
                if (!PowderInventory.UpdateQty(databasePath, perfferedPowderId, newPowderPounds, newPowderGrains, 
                    out errOut)) throw new Exception(errOut);

            }
            catch (Exception e)
            {
                errOut = ErrorMessage("MetallicUpdate", e);
            }
            return bAns;
        }
    }
}
