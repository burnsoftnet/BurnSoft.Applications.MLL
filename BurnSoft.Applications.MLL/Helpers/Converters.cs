using System;
using Microsoft.VisualBasic;
// ReSharper disable UnusedMember.Local

namespace BurnSoft.Applications.MLL.Helpers
{
    /// <summary>
    /// Class Converters contains functions that can be used to conver tvalues for the application
    /// </summary>
    public class Converters
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string _classLocation = "BurnSoft.Applications.MLL.Helpers.Converters";
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
        /// Converts string to Double and removes any non characters
        /// </summary>
        /// <param name="strValue">The string value.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Double.</returns>
        public static double ConvertToNumber(string strValue, out string errOut)
        {
            double dAns = 0;
            errOut = "";
            try
            {
                int intChar = strValue.Length;
                string newValue = "";
                string lastValue = "";
                bool needDiv = false;
                for (int i = 1; i <= intChar; i++)
                {
                    var curValue = Strings.Mid(strValue, i, 1);
                    if (curValue == " ")
                        break;
                    if (Information.IsNumeric(curValue))
                    {
                        if (Strings.Len(lastValue) != 0)
                            lastValue = Strings.Mid(newValue, Strings.Len(newValue), 1);
                        else
                            lastValue = curValue;

                        if (!needDiv)
                            newValue += curValue;
                        else
                            newValue = $"{Convert.ToDouble(curValue) / Convert.ToDouble(lastValue)}";
                        needDiv = false;
                    }
                    else
                        switch (curValue)
                        {
                            case ".":
                            {
                                newValue += curValue;
                                needDiv = false;
                                break;
                            }

                            case "/":
                            {
                                needDiv = true;
                                break;
                            }
                        }
                }
                dAns = Convert.ToDouble(newValue);
            }
            catch (Exception ex)
            {
                errOut = ErrorMessage("ConvertToNumber", ex);
            }
            return dAns;
        }
        /// <summary>
        /// Converts the ounces to double.
        /// </summary>
        /// <param name="sValue">The s value.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Double.</returns>
        public static double ConvertOuncesToDouble(string sValue, out string errOut)
        {
            double dAns = 0;
            errOut = "";
            try
            {
                int charCount = Strings.Len(sValue);
                string newValue = "";
                string lastValue = "";
                string endValue = "0";
                bool needDiv = false;
                bool isDec = false;
                for (int i = 1; i <= charCount; i++)
                {
                    var curValue = Strings.Mid(sValue, i, 1);
                    var isFraction = false;
                    if (Information.IsNumeric(curValue))
                    {
                        if (!needDiv)
                        {
                            newValue = curValue;
                            isDec = false;
                        }
                        else
                        {
                            newValue = $"{Convert.ToDouble(lastValue) / Convert.ToDouble(curValue)}";
                            isDec = true;
                        }
                        needDiv = false;
                        lastValue = curValue;
                    }
                    else
                        switch (curValue)
                        {
                            case ".":
                                {
                                    newValue += curValue;
                                    needDiv = false;
                                    break;
                                }

                            case "/":
                                {
                                    needDiv = true;
                                    break;
                                }

                            default:
                                {
                                    newValue = "";
                                    break;
                                }
                        }
                    if (Strings.Mid(sValue, i + 1, 1) == "/")
                        isFraction = true;
                    if (!isFraction & !needDiv)
                    {
                        if (!isDec)
                            endValue += newValue;
                        else
                            endValue = $"{Convert.ToDouble(endValue) + Convert.ToDouble(newValue)}";
                    }
                }
                dAns = Convert.ToDouble(endValue);
            }
            catch (Exception ex)
            {
                errOut = ErrorMessage("ConvertOuncesToDouble", ex);
            }
            return dAns;
        }


    }
}
