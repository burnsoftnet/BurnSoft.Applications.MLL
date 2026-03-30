using BurnSoft.Applications.MLL.Global;
using System;

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
        /// Metallics the update qty for items used in make laoded ammunition process
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
                if (!UpdateBullets(databasePath, bulletId, bulletsInStockQty, qtyMade, out errOut)) throw new Exception(errOut);
                if (!UpdatePrimers(databasePath, primerId, primersInStockQty, qtyMade, out errOut)) throw new Exception(errOut);
                if (!UpdateCases(databasePath, caseId, caseInStockQty, qtyMade, out errOut)) throw new Exception(errOut);
                if (!UpdatePowder(databasePath, perfferedPowderId, powderInStockGrains, midRangePowderUsed, qtyMade, 
                    out errOut)) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("MetallicUpdate", e);
            }
            return bAns;
        }
        /// <summary>
        /// Shotguns the update qty for items used in make laoded ammunition process
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="qtyMade">The qty made.</param>
        /// <param name="shotDetailsId">The shot details identifier.</param>
        /// <param name="shotDetailsQty">The shot details qty.</param>
        /// <param name="isSlug">if set to <c>true</c> [is slug].</param>
        /// <param name="shotDetailsShotOz">The shot details shot oz.</param>
        /// <param name="shotDetailsShotGrains">The shot details shot grains.</param>
        /// <param name="shotDetailsMidRangeLoad">The shot details mid range load.</param>
        /// <param name="wadsInStock">The wads in stock.</param>
        /// <param name="wadsId">The wads identifier.</param>
        /// <param name="primersInStockQty">The primers in stock qty.</param>
        /// <param name="primerId">The primer identifier.</param>
        /// <param name="caseInStockQty">The case in stock qty.</param>
        /// <param name="caseId">The case identifier.</param>
        /// <param name="powderInStockGrains">The powder in stock grains.</param>
        /// <param name="perfferedPowderId">The perffered powder identifier.</param>
        /// <param name="midRangePowderUsed">The mid range powder used.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool ShotgunUpdate(string databasePath, long qtyMade, long shotDetailsId, long shotDetailsQty, 
            bool isSlug, double shotDetailsShotOz, double shotDetailsShotGrains, double shotDetailsMidRangeLoad, 
            long wadsInStock, long wadsId, long primersInStockQty, long primerId, long caseInStockQty, 
            long caseId, double powderInStockGrains, long perfferedPowderId, double midRangePowderUsed, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                if (isSlug)
                {
                    long newShotDetails = shotDetailsQty * qtyMade;
                    // TODO: #36  UPDATE List_SG_ShotType_Details set Qty=" & newShotDetails & " where ID=" & shotDetailsId
                }
                else
                {
                    double newShotOz = shotDetailsShotOz - (shotDetailsMidRangeLoad * qtyMade);
                    double newShotGrains = newShotOz * WeightValues.WEIGHT_GRAMS_OZ;
                    double newShotPounds = newShotOz / WeightValues.WEIGHT_OZ_1LBS;
                    //QL = "UPDATE List_SG_ShotType_Details set weight=" & dNewShotLBS & _
                    //        ", ounces=" & dNewShotOz & ", grams=" & dNewShotGrans & " where ID=" & BID
                }
                if (!UpdateWads(databasePath, primerId, primersInStockQty, qtyMade, out errOut)) throw new Exception(errOut);
                if (!UpdatePrimers(databasePath, primerId, primersInStockQty, qtyMade, out errOut)) throw new Exception(errOut);
                if (!UpdateHulls(databasePath, caseId, caseInStockQty, qtyMade, out errOut)) throw new Exception(errOut);
                if (!UpdatePowder(databasePath, perfferedPowderId, powderInStockGrains, midRangePowderUsed, qtyMade,
                    out errOut)) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("ShotgunUpdate", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the powder.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="powderInStockGrains">The powder in stock grains.</param>
        /// <param name="midRangePowderUsed">The mid range powder used.</param>
        /// <param name="qtyMade">The qty made.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        internal static bool UpdatePowder(string databasePath, long id, double powderInStockGrains, 
            double midRangePowderUsed, long qtyMade, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                double newPowderGrains = powderInStockGrains - (midRangePowderUsed * qtyMade);
                double newPowderPounds = Math.Round(newPowderGrains / WeightValues.WEIGHT_GRAINS_1LBS, 3);
                if (!PowderInventory.UpdateQty(databasePath, id, newPowderPounds, newPowderGrains, 
                    out errOut)) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdatePowder", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the primers.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="qtyMade">The qty made.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        internal static bool UpdatePrimers(string databasePath, long id, long qty, long qtyMade, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                long newQty = qty - qtyMade;
                if (!PrimerInventory.UpdateQty(databasePath, id, newQty, out errOut)) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdatePrimers", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the cases.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="qtyMade">The qty made.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        internal static bool UpdateCases(string databasePath, long id, long qty, long qtyMade, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                long newQty = qty - qtyMade;
                if (!CaseInventory.UpdateQty(databasePath, id, newQty, out errOut)) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateCases", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the hulls.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="qtyMade">The qty made.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        internal static bool UpdateHulls(string databasePath, long id, long qty, long qtyMade, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                long newQty = qty - qtyMade;
                if (!ShotgunHullInventory.UpdateQty(databasePath, id, (int)newQty, out errOut)) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateHulls", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the bullets.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="qtyMade">The qty made.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        internal static bool UpdateBullets(string databasePath, long id, long qty, long qtyMade, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                long newQty = qty - qtyMade;
                if (!BulletsInventory.UpdateQty(databasePath, id, newQty, out errOut)) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateBullets", e);
            }
            return bAns;
        }
        /// <summary>
        /// Updates the wads.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="qty">The qty.</param>
        /// <param name="qtyMade">The qty made.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        internal static bool UpdateWads(string databasePath, long id, long qty, long qtyMade, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                int newQty = Convert.ToInt32(qty - qtyMade);
                if (!WadInventory.UpdateQty(databasePath, id, newQty, out errOut)) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpdateBullets", e);
            }
            return bAns;
        }
    }
}
