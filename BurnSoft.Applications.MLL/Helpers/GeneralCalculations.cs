using System;

namespace BurnSoft.Applications.MLL.Helpers
{
    /// <summary>
    /// Class GeneralCalculations handles some math and 
    /// logic calculations used in the application
    /// </summary>
    public class GeneralCalculations
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string _classLocation = "BurnSoft.Applications.MLL.Helpers.GeneralCalculations";
        /// <summary>
        /// Errors the message for regular Exceptions
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, Exception e) => $"{_classLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for access violations
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, AccessViolationException e) => $"{_classLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for invalid cast exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, InvalidCastException e) => $"{_classLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message argument exception
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentException e) => $"{_classLocation}.{functionName} - {e.Message}";
        /// <summary>
        /// Errors the message for argument null exception.
        /// </summary>
        /// <param name="functionName">Name of the function.</param>
        /// <param name="e">The e.</param>
        /// <returns>System.String.</returns>
        private static string ErrorMessage(string functionName, ArgumentNullException e) => $"{_classLocation}.{functionName} - {e.Message}";
        #endregion                
        /// <summary>
        /// Calculates the metallic rounds to make.
        /// </summary>
        /// <param name="bulletQty">The bullet qty.</param>
        /// <param name="caseQty">The case qty.</param>
        /// <param name="primerQty">The primer qty.</param>
        /// <param name="powderQty">The powder qty.</param>
        /// <param name="powderMidRangeLoad">The powder mid range load.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long CalculateMetallicRoundsToMake(long bulletQty, long caseQty, long primerQty, double powderQty, 
            double powderMidRangeLoad, out string errOut)
        {
            long lAns = 0;
            errOut = "";
            try
            {
                long lowMarker = 0;
                double powderPerBullet = (powderQty / powderMidRangeLoad);

                lowMarker = bulletQty;
                if (lowMarker > caseQty) lowMarker = caseQty;
                if (lowMarker > primerQty) lowMarker = primerQty;
                if (lowMarker > powderPerBullet) lowMarker = Convert.ToInt64(powderPerBullet);
                lAns = lowMarker;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("CalculateMetallicRoundsToMake", e);
            }
            return lAns;
        }
        /// <summary>
        /// Calculates the shotgun rounds to make.
        /// </summary>
        /// <param name="shotOzQty">The shot oz qty.</param>
        /// <param name="shotPrefferedLoad">The shot preffered load.</param>
        /// <param name="caseQty">The case qty.</param>
        /// <param name="wadQty">The wad qty.</param>
        /// <param name="powderQty">The powder qty.</param>
        /// <param name="powderMidRangeLoad">The powder mid range load.</param>
        /// <param name="primerQty">The primer qty.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long CalculateShotgunRoundsToMake(double shotOzQty, double shotPrefferedLoad, long caseQty,
            long wadQty, double powderQty, double powderMidRangeLoad, long primerQty, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                long lowMarker = 0;
                double powderPerBullet = (powderQty / powderMidRangeLoad);
                double countMakeAble = (shotOzQty / shotPrefferedLoad);
                lowMarker = (long)countMakeAble;
                if (lowMarker > caseQty) lowMarker = caseQty;
                if (lowMarker > wadQty) lowMarker = wadQty;
                if (lowMarker > primerQty) lowMarker = primerQty;
                if (lowMarker > powderPerBullet) lowMarker = Convert.ToInt64(powderPerBullet);
                lAns = lowMarker;

            }
            catch (Exception e)
            {
                errOut = ErrorMessage("CalculateShotgunRoundsToMake", e);
            }
            return lAns;
        }
        /// <summary>
        /// Calculates the shotgun slug rounds to make.
        /// </summary>
        /// <param name="slugQty">The slug qty.</param>
        /// <param name="caseQty">The case qty.</param>
        /// <param name="wadQty">The wad qty.</param>
        /// <param name="powderQty">The powder qty.</param>
        /// <param name="powderMidRangeLoad">The powder mid range load.</param>
        /// <param name="primerQty">The primer qty.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Int64.</returns>
        public static long CalculateShotgunSlugRoundsToMake(long slugQty, long caseQty,
            long wadQty, double powderQty, double powderMidRangeLoad, long primerQty, out string errOut)
        {
            errOut = "";
            long lAns = 0;
            try
            {
                long lowMarker = 0;
                double powderPerBullet = (powderQty / powderMidRangeLoad);
                lowMarker = slugQty;
                if (lowMarker > caseQty) lowMarker = caseQty;
                if (lowMarker > wadQty) lowMarker = wadQty;
                if (lowMarker > primerQty) lowMarker = primerQty;
                if (lowMarker > powderPerBullet) lowMarker = Convert.ToInt64(powderPerBullet);
                lAns = lowMarker;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("CalculateShotgunSlugRoundsToMake", e);
            }
            return lAns;
        }
    }
}
