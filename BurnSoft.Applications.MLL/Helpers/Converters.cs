using System;
using BurnSoft.Applications.MLL.Global;
using Microsoft.VisualBasic;
// ReSharper disable UnusedMember.Local

namespace BurnSoft.Applications.MLL.Helpers
{
    /// <summary>
    /// Class Converters contains functions that can be used to convert values for the application
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
        /// <summary>
        /// Converts the value to a specifict weight type, so if you had 2 lbs of powder you can convert it to grains etc.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="convertTo">The convert to.</param>
        /// <param name="convertFrom">The convert from.</param>
        /// <returns>System.Double.</returns>
        public static double ConvertWeight(double value, WeightValues.WeightType convertTo, WeightValues.WeightType convertFrom, out string errOut)
        {
            double dAns = 0;
            errOut = "";
            try
            {
                switch (convertTo)
                {
                    case WeightValues.WeightType.Pounds:
                    {
                        if (convertFrom == WeightValues.WeightType.Grains)
                            dAns = value / WeightValues.WEIGHT_GRAINS_1LBS;
                        else if (convertFrom == WeightValues.WeightType.Grams)
                            dAns = value / WeightValues.WEIGHT_GRAMS_1LBS;
                        break;
                    }

                    case WeightValues.WeightType.Grams:
                    {
                        if (convertFrom == WeightValues.WeightType.Pounds)
                            dAns = value * WeightValues.WEIGHT_GRAMS_1LBS;
                        else if (convertFrom == WeightValues.WeightType.Grains)
                            dAns = value / WeightValues.WEIGHT_GRAINS_1GM;
                        break;
                    }

                    case WeightValues.WeightType.Grains:
                    {
                        if (convertFrom == WeightValues.WeightType.Pounds)
                            dAns = value * WeightValues.WEIGHT_GRAINS_1LBS;
                        else if (convertFrom == WeightValues.WeightType.Grams)
                            dAns = value * WeightValues.WEIGHT_GRAINS_1GM;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("ConvertWeight", e);
            }
            return Convert.ToDouble(Strings.FormatNumber(dAns, 6));
        }

        /// <summary>
        /// Convs string to number and get rid of anything is is not a number.
        /// </summary>
        /// <param name="strValue">The string value.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Double.</returns>
        public static double ConvToNum(string strValue, out string errOut)
        {
            double dAns = 0;
            errOut = "";
            try
            {
                int intChar = Strings.Len(strValue);
                int i = 0;
                string CurValue = "";
                string NewValue = "";
                string LastValue = "";
                bool NeedDiv = false;
                for (i = 1; i <= intChar; i++)
                {
                    CurValue = Strings.Mid(strValue, i, 1);
                    if (CurValue == " ")
                        break;
                    if (Information.IsNumeric(CurValue))
                    {
                        if (Strings.Len(LastValue) != 0)
                            LastValue = Strings.Mid(NewValue, Strings.Len(NewValue), 1);
                        else
                            LastValue = CurValue;
                        if (!NeedDiv)
                            NewValue += CurValue;
                        else
                            NewValue = Convert.ToString(Convert.ToDouble(CurValue) / Convert.ToDouble(LastValue));
                        NeedDiv = false;
                    }
                    else
                        switch (CurValue)
                        {
                            case ".":
                                {
                                    NewValue += CurValue;
                                    NeedDiv = false;
                                    break;
                                }

                            case "/":
                                {
                                    NeedDiv = true;
                                    break;
                                }
                        }
                }
                dAns = Convert.ToDouble(NewValue);
            }
            catch (Exception ex)
            {
                errOut = ErrorMessage("ConvertToNum", ex);
            }
            return dAns;
        }

        /// <summary>
        /// Converts the ounces to double.
        /// </summary>
        /// <param name="sValue">The string value.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.Double.</returns>
        public static double ConvertOzToDouble(string sValue, out string errOut)
        {
            double dAns = 0;
            errOut = "";
            try
            {
                int char_count = Strings.Len(sValue);
                int i = 0;
                string CurValue = "";
                string NewValue = "";
                string LastValue = "";
                string EndValue = "0";
                bool NeedDiv = false;
                bool isFraction = false;
                bool IsDec = false;
                for (i = 1; i <= char_count; i++)
                {
                    CurValue = Strings.Mid(sValue, i, 1);
                    isFraction = false;
                    if (Information.IsNumeric(CurValue))
                    {
                        if (!NeedDiv)
                        {
                            NewValue = CurValue;
                            IsDec = false;
                        }
                        else
                        {
                            NewValue = Convert.ToString(Convert.ToDouble(LastValue) / Convert.ToDouble(CurValue));
                            IsDec = true;
                        }
                        NeedDiv = false;
                        LastValue = CurValue;
                    }
                    else
                        switch (CurValue)
                        {
                            case ".":
                                {
                                    NewValue += CurValue;
                                    NeedDiv = false;
                                    break;
                                }

                            case "/":
                                {
                                    NeedDiv = true;
                                    break;
                                }

                            default:
                                {
                                    NewValue = "";
                                    break;
                                }
                        }
                    if (Strings.Mid(sValue, i + 1, 1) == "/")
                        isFraction = true;
                    if (!isFraction & !NeedDiv)
                    {
                        if (!IsDec)
                            EndValue += NewValue;
                        else
                            EndValue = Convert.ToString(Convert.ToDouble(EndValue) + Convert.ToDouble(NewValue));
                    }
                }
                dAns = Convert.ToDouble(EndValue);
            }
            catch (Exception ex)
            {
                errOut = ErrorMessage("ConvertOZToDouble", ex);
            }
            return dAns;
        }


        /// <summary>
        /// Converts long double  to dollars format, at least with 3 decimal places on thr right.
        /// </summary>
        /// <param name="dValue">The d value.</param>
        /// <returns>System.Double.</returns>
        public static double ConvertToDollars(double dValue)
        {
            double dAns = Math.Round(dValue, 2);
            return dAns;
        }


    }
}
