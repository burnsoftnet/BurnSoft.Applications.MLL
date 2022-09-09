using System;
using BurnSoft.Universal;
using Microsoft.VisualBasic;
// ReSharper disable CompareOfFloatsByEqualityOperator
// ReSharper disable UnusedMember.Global

namespace BurnSoft.Applications.MLL.Helpers
{
    /// <summary>
    /// Class General functions that are used through out the program that have no general category
    /// </summary>
    public class General
    {
        /// <summary>
        /// Fluffs the content for database
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.String.</returns>
        public static string FluffContent(string value, string defaultValue = "  ")
        {
            BSOtherObjects obj = new BSOtherObjects();
            return obj.FC(value, defaultValue);
        }
        /// <summary>
        /// Fluffs the content to double
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="defaultValue">The default value.</param>
        /// <returns>System.Double.</returns>
        public static double FluffContent(string value, double defaultValue =0)
        {
            BSOtherObjects obj = new BSOtherObjects();
            double dAns = Convert.ToDouble(obj.FC(value, $"{defaultValue}"));
            return dAns;
        }
        /// <summary>
        /// Uns the content of the fluff.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string UnFluffContent(string value)
        {
            return value.Replace("''","'");
        }
        /// <summary>
        /// Determines whether the specified string value is required.
        /// </summary>
        /// <param name="strValue">The string value.</param>
        /// <param name="strField">The string field.</param>
        /// <param name="strTitle">The string title.</param>
        /// <returns><c>true</c> if the specified string value is required; otherwise, <c>false</c>.</returns>
        public static bool IsRequired(string strValue, string strField, string strTitle)
        {
            bool bAns = !Strings.Len(Strings.Trim(strValue)).Equals(0);

            if (bAns == false)
                Interaction.MsgBox("Please put in a value for " + strField + "!", MsgBoxStyle.Critical, strTitle);
            return bAns;
        }
        /// <summary>
        /// Determines whether the specified l value is required.
        /// </summary>
        /// <param name="lValue">The l value.</param>
        /// <param name="lDefault">The l default.</param>
        /// <param name="strField">The string field.</param>
        /// <param name="strTitle">The string title.</param>
        /// <returns><c>true</c> if the specified l value is required; otherwise, <c>false</c>.</returns>
        public static bool IsRequired(long lValue, long lDefault, string strField, string strTitle)
        {
            bool bAns = !lValue.Equals(lDefault);
            if (bAns == false)
                Interaction.MsgBox("Please put in a value for " + strField + "!", MsgBoxStyle.Critical, strTitle);
            return bAns;
        }
        /// <summary>
        /// Determines whether the specified l value is required.
        /// </summary>
        /// <param name="lValue">The l value.</param>
        /// <param name="lDefault">The l default.</param>
        /// <param name="strField">The string field.</param>
        /// <param name="strTitle">The string title.</param>
        /// <returns><c>true</c> if the specified l value is required; otherwise, <c>false</c>.</returns>
        public static bool IsRequired(double lValue, double lDefault, string strField, string strTitle)
        {
            bool bAns = !lValue.Equals(lDefault);
            
            if (bAns == false)
                Interaction.MsgBox("Please put in a value for " + strField + "!", MsgBoxStyle.Critical, strTitle);
            return bAns;
        }


    }
}
