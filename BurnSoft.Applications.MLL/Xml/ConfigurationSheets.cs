using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.Applications.MLL.Xml
{
    /// <summary>
    /// Class ConfigurationSheets XML Export and save to file for Metallic Configs.
    /// </summary>
    public class ConfigurationSheets
    {
        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string _classLocation = "BurnSoft.Applications.MLL.Xml.ConfigurationSheets";
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
        public static bool Generate(string databasePath, long configId, string filePath, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                string body = $"<?xml version=\"1.0\" encoding=\"utf-8\" ?>{Environment.NewLine}";
                body += $"<Inventory>{Environment.NewLine}";
                List<ConfigListAllMetallicData> lst = ConfigListAll.Metallic(databasePath, configId, out errOut);
                body += $"{GenerateConfigSection(databasePath, lst, out errOut)}";
                body += $"";
                body += $"";
                //TODO Add Function Here
                body += $"</Inventory>{Environment.NewLine}";
                body = body.Replace("&", XmlConstants.Ampersand);
                FileIO obj = new FileIO();
                obj.DeleteFile(filePath);
                obj.AppendToFile(filePath, body);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("Generate", e);
            }
            return bAns;
        }

        private static string LineFormat(string xmlField, string value)
        {
            return $"<{xmlField}>{value}</{xmlField}>";
        }

        private static string LineFormat(string xmlField, bool value)
        {
            return $"<{xmlField}>{value}</{xmlField}>";
        }

        private static string LineFormat(string xmlField, long value)
        {
            return $"<{xmlField}>{value}</{xmlField}>";
        }

        private static string LineFormat(string xmlField, int value)
        {
            return $"<{xmlField}>{value}</{xmlField}>";
        }

        private static string LineFormat(string xmlField, double value)
        {
            return $"<{xmlField}>{value}</{xmlField}>";
        }

        private static string GenerateConfigSection(string databasePath, List<ConfigListAllMetallicData> configData, out string errOut)
        {
            errOut = "";
            string body = "";
            try
            {
                long configId = 0;
                body = "    <Details>";
                foreach (ConfigListAllMetallicData i in configData)
                {
                    foreach (ConfigNameList c in i.ConfigSection)
                    {
                        configId = c.Id;
                        body += $"       {XmlFormating.LineFormat("ConfigName", c.Name)}";
                        body += $"       {XmlFormating.LineFormat("IsPersonal", c.IsPersonal)}";
                        body += $"       {XmlFormating.LineFormat("IsShotGun", c.IsShotGun)}";
                        body += $"       {XmlFormating.LineFormat("Notes", c.Notes)}";
                    }

                    foreach(ConfigListDataMetalicData s in i.SettingsDetails)
                    {
                        string ammoType = AmmuntionType.GetAmmoType(databasePath, s.AmmoTypeId, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        string caliber = CaliberInventory.GetName(databasePath, s.CaliberId, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        body += $"       {XmlFormating.LineFormat("AmmoType", ammoType)}";
                        body += $"       {XmlFormating.LineFormat("Caliber", caliber)}";
                        body += $"       {XmlFormating.LineFormat("Notes", s.Source)}";
                    }
                }
                body += "    </Details>";
            }
            catch (Exception e)
            {

            }
            return body ;
        }
    }
}
