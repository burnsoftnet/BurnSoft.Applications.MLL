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


            }
            catch (Exception e)
            {
                errOut = ErrorMessage("MetallicUpdate", e);
            }
            return bAns;
        }
    }
}
