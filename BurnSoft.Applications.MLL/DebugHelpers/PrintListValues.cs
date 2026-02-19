using BurnSoft.Applications.MLL.Types;
using System;
using System.Collections.Generic;


namespace BurnSoft.Applications.MLL.DebugHelpers
{
    /// <summary>
    /// Get the data from the lists and put them in a format that can be 
    /// printed or displated in abother windows for debugging and testing
    /// </summary>
    public class PrintListValues
    {
        /// <summary>
        /// Personals the information data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string PersonalInformationData(List<PersonalInformation> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (PersonalInformation p in value)
                {
                    sAns += $"id : {p.Id}{Environment.NewLine}";
                    sAns += $"LoadName : {p.LoadName}{Environment.NewLine}";
                    sAns += $"Name : {p.Name}{Environment.NewLine}";
                    sAns += $"Address : {p.Address}{Environment.NewLine}";
                    sAns += $"City : {p.City}{Environment.NewLine}";
                    sAns += $"State : {p.State}{Environment.NewLine}";
                    sAns += $"ZipCode : {p.ZipCode}{Environment.NewLine}";
                    sAns += $"Phone : {p.Phone}{Environment.NewLine}";
                    sAns += $"License : {p.License}{Environment.NewLine}";
                    sAns += $"UseLock : {p.UseLock}{Environment.NewLine}";
                    sAns += $"UserName : {p.UserName}{Environment.NewLine}";
                    sAns += $"Password : {p.Password}{Environment.NewLine}";
                    sAns += $"Forgot : {p.Forgot}{Environment.NewLine}";
                    sAns += $"ForgetPhrase : {p.ForgetPhrase}{Environment.NewLine}";
                    sAns += $"LastSync : {p.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }

        /// <summary>
        /// Logins the information only data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LoginInformationOnlyData(List<LoginInformationOnly> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (LoginInformationOnly p in value)
                {
                    sAns += $"UseLock : {p.UseLock}{Environment.NewLine}";
                    sAns += $"UserName : {p.UserName}{Environment.NewLine}";
                    sAns += $"Password : {p.Password}{Environment.NewLine}";
                    sAns += $"Forgot : {p.Forgot}{Environment.NewLine}";
                    sAns += $"ForgetPhrase : {p.ForgetPhrase}{Environment.NewLine}";
                }
            }
            return sAns;
        }

        /// <summary>
        /// Configurations the list data metalic data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ConfigListDataMetalicData(List<ConfigListDataMetalic> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ConfigListDataMetalic v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"ConfgId : {v.ConfgId}{Environment.NewLine}";
                    sAns += $"AmmoTypeId : {v.AmmoTypeId}{Environment.NewLine}";
                    sAns += $"CaliberId : {v.CaliberId}{Environment.NewLine}";
                    sAns += $"BulletId : {v.BulletId}{Environment.NewLine}";
                    sAns += $"PrimerId : {v.PrimerId}{Environment.NewLine}";
                    sAns += $"CaseId : {v.CaseId}{Environment.NewLine}";
                    sAns += $"Source : {v.Source}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Registries the settings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string RegistrySettingsData(List<RegistrySettings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (RegistrySettings v in value)
                {
                    sAns += $"TrackHistoryDays : {v.TrackHistoryDays}{Environment.NewLine}";
                    sAns += $"LastSucBackup : {v.LastSucBackup}{Environment.NewLine}";
                    sAns += $"AlertOnBackUp : {v.AlertOnBackUp}{Environment.NewLine}";
                    sAns += $"TrackHistory : {v.TrackHistory}{Environment.NewLine}";
                    sAns += $"AutoBackup : {v.AutoBackup}{Environment.NewLine}";
                    sAns += $"UseOrgImage : {v.UseOrgImage}{Environment.NewLine}";
                    sAns += $"IndvReports : {v.IndvReports}{Environment.NewLine}";
                    sAns += $"ConfigSort : {v.ConfigSort}{Environment.NewLine}";
                    sAns += $"NumberFormat : {v.NumberFormat}{Environment.NewLine}";
                    sAns += $"AutoUpdate : {v.AutoUpdate}{Environment.NewLine}";
                    sAns += $"UseProxy : {v.UseProxy}{Environment.NewLine}";
                    sAns += $"LoaderTypeShotGun : {v.LoaderTypeShotGun}{Environment.NewLine}";
                    sAns += $"LoaderTypeMetalic : {v.LoaderTypeMetalic}{Environment.NewLine}";
                    sAns += $"ViewFps : {v.ViewFps}{Environment.NewLine}";
                    sAns += $"ViewCups : {v.ViewCups}{Environment.NewLine}";
                    sAns += $"DefaultList : {v.DefaultList}{Environment.NewLine}";
                    sAns += $"BackupOnExit : {v.BackupOnExit}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Firearms the collection data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string FirearmCollectionData(List<FirearmCollection> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (FirearmCollection v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"MyGunCollectionId : {v.MyGunCollectionId}{Environment.NewLine}";
                    sAns += $"FullName : {v.FullName}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Model : {v.Model}{Environment.NewLine}";
                    sAns += $"Caliber : {v.Caliber}{Environment.NewLine}";
                    sAns += $"Barrel : {v.Barrel}{Environment.NewLine}";
                    sAns += $"SerialNo : {v.SerialNo}{Environment.NewLine}";
                    sAns += $"GunType : {v.GunType}{Environment.NewLine}";
                    sAns += $"Exclude : {v.Exclude}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Bullets the listings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string BulletListingsData(List<BulletListings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (BulletListings v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"Diameter : {v.Diameter}{Environment.NewLine}";
                    sAns += $"Weight : {v.Weight}{Environment.NewLine}";
                    sAns += $"SectionDensity : {v.SectionDensity}{Environment.NewLine}";
                    sAns += $"PartNumber : {v.PartNumber}{Environment.NewLine}";
                    sAns += $"BallisticCoeffcient : {v.BallisticCoeffcient}{Environment.NewLine}";
                    sAns += $"BullerType : {v.BullerType}{Environment.NewLine}";
                    sAns += $"Qty : {v.Qty}{Environment.NewLine}";
                    sAns += $"Price : {v.Price}{Environment.NewLine}";
                    sAns += $"CaliberId : {v.CaliberId}{Environment.NewLine}";
                    sAns += $"EsitmatedPricePerBullet : {v.EsitmatedPricePerBullet}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
    }
}
