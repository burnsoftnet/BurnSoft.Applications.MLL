using BurnSoft.Applications.MLL.ConfigSheets;
using BurnSoft.Applications.MLL.Inventory;
using BurnSoft.Applications.MLL.Types;
using BurnSoft.Universal;
using System;
using System.Collections.Generic;

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
        /// <summary>
        /// Generates The XML File report for the selected configuration id that you pass and
        /// saves it to the selected file.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configId">The configuration identifier.</param>
        /// <param name="filePath">The file path.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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
                body += $"{GenerateCaseSection(databasePath, lst, out errOut)}";
                body += $"{GeneratePrimerSection(databasePath, lst, out errOut)}";
                body += $"{GenerateBulletSection(databasePath, lst, out errOut)}";
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
        /// <summary>
        /// Generates the configuration section.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configData">The configuration data.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        private static string GenerateConfigSection(string databasePath, List<ConfigListAllMetallicData> configData, out string errOut)
        {
            errOut = "";
            string body = "";
            try
            {
                long configId = 0;
                body = $"    <Details>{Environment.NewLine}";
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
                body += $"    </Details>{Environment.NewLine}";
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GenerateConfigSection", e);
            }
            return body ;
        }
        /// <summary>
        /// Generates the case section.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configData">The configuration data.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        private static string GenerateCaseSection(string databasePath, List<ConfigListAllMetallicData> configData, out string errOut)
        {
            errOut = "";
            string body = "";
            try
            {
                body = $"    <List_Case>{Environment.NewLine}";
                foreach (ConfigListAllMetallicData i in configData)
                {
                    foreach (ConfigListDataMetalicData s in i.SettingsDetails)
                    {
                        long caseId = s.CaseId;
                        List<CaseListings> lst = CaseInventory.GetDetails(databasePath, caseId, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        foreach (CaseListings c in lst)
                        {
                            body += $"       {XmlFormating.LineFormat("Manufacturer", c.Manufacturer)}";
                            body += $"       {XmlFormating.LineFormat("Name", c.Name)}";
                            body += $"       {XmlFormating.LineFormat("ttl", c.TrimToLength)}";
                            body += $"       {XmlFormating.LineFormat("TimesUsed", c.TimesUsed)}";
                        }
                    }
                }
                body += $"    </List_Case>{Environment.NewLine}";
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GenerateCaseSection", e);
            }
            return body;
        }
        /// <summary>
        /// Generates the primer section.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configData">The configuration data.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        private static string GeneratePrimerSection(string databasePath, List<ConfigListAllMetallicData> configData, out string errOut)
        {
            errOut = "";
            string body = "";
            try
            {
                body = $"    <General_Primer>{Environment.NewLine}";
                foreach (ConfigListAllMetallicData i in configData)
                {
                    foreach (ConfigListDataMetalicData s in i.SettingsDetails)
                    {
                        long Id = s.PrimerId;
                        List<PrimerListings> lst = PrimerInventory.GetDetails(databasePath, Id, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        foreach (PrimerListings c in lst)
                        {
                            body += $"       {XmlFormating.LineFormat("Manufacturer", c.Manufacturer)}";
                            body += $"       {XmlFormating.LineFormat("Name", c.Name)}";
                            body += $"       {XmlFormating.LineFormat("Primer_Type", c.PrimerType)}";
                        }
                    }
                }
                body += $"    </General_Primer>{Environment.NewLine}";
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GeneratePrimerSection", e);
            }
            return body;
        }
        /// <summary>
        /// Generates the bullet section.
        /// </summary>
        /// <param name="databasePath">The database path.</param>
        /// <param name="configData">The configuration data.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        private static string GenerateBulletSection(string databasePath, List<ConfigListAllMetallicData> configData, out string errOut)
        {
            errOut = "";
            string body = "";
            try
            {
                body = $"    <List_Bullets>{Environment.NewLine}";
                foreach (ConfigListAllMetallicData i in configData)
                {
                    foreach (ConfigListDataMetalicData s in i.SettingsDetails)
                    {
                        long Id = s.BulletId;
                        List<BulletListings> lst = BulletsInventory.GetDetails(databasePath, Id, out errOut);
                        if (errOut.Length > 0) throw new Exception(errOut);
                        foreach (BulletListings c in lst)
                        {
                            string bulletType = CaliberInventory.GetName(databasePath, c.BulletType, out errOut);
                            if (errOut.Length > 0) throw new Exception(errOut);
                            body += $"       {XmlFormating.LineFormat("Manufacturer", c.Manufacturer)}";
                            body += $"       {XmlFormating.LineFormat("Name", c.Name)}";
                            body += $"       {XmlFormating.LineFormat("Diameter", c.Diameter)}";
                            body += $"       {XmlFormating.LineFormat("Weight", c.Weight)}";
                            body += $"       {XmlFormating.LineFormat("Sec_Den", c.SectionDensity)}";
                            body += $"       {XmlFormating.LineFormat("Part_number", c.PartNumber)}";
                            body += $"       {XmlFormating.LineFormat("Ballistic_Coefficient", c.BallisticCoeffcient)}";
                            body += $"       {XmlFormating.LineFormat("Bullet_Type", bulletType)}";
                        }
                    }
                }
                body += $"    </List_Bullets>{Environment.NewLine}";
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GenerateBulletSection", e);
            }
            return body;
        }
    }
}
