
using System;

namespace BurnSoft.Applications.MLL.Xml
{
    /// <summary>
    /// Class XmlFormating and standards
    /// </summary>
    public class XmlFormating
    {
        /// <summary>
        /// Lines the format.
        /// </summary>
        /// <param name="xmlField">The XML field.</param>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LineFormat(string xmlField, string value)
        {
            return $"<{xmlField}>{value}</{xmlField}>{Environment.NewLine}";
        }
        /// <summary>
        /// Lines the format.
        /// </summary>
        /// <param name="xmlField">The XML field.</param>
        /// <param name="value">if set to <c>true</c> [value].</param>
        /// <returns>System.String.</returns>
        public static string LineFormat(string xmlField, bool value)
        {
            return $"<{xmlField}>{value}</{xmlField}>{Environment.NewLine}";
        }
        /// <summary>
        /// Lines the format.
        /// </summary>
        /// <param name="xmlField">The XML field.</param>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LineFormat(string xmlField, long value)
        {
            return $"<{xmlField}>{value}</{xmlField}>{Environment.NewLine}";
        }
        /// <summary>
        /// Lines the format.
        /// </summary>
        /// <param name="xmlField">The XML field.</param>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LineFormat(string xmlField, int value)
        {
            return $"<{xmlField}>{value}</{xmlField}>{Environment.NewLine}";
        }
        /// <summary>
        /// Lines the format.
        /// </summary>
        /// <param name="xmlField">The XML field.</param>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LineFormat(string xmlField, double? value)
        {
            return $"<{xmlField}>{value}</{xmlField}>{Environment.NewLine}";
        }
    }
}
