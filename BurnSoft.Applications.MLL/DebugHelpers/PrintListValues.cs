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
        public static string ConfigListDataMetalicDataLst(List<ConfigListDataMetalicData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ConfigListDataMetalicData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"ConfgId : {v.ConfgNameId}{Environment.NewLine}";
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
        /// Configurations the list data shotgun data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ConfigListDataShotgunDataData(List<ConfigListDataShotgunData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ConfigListDataShotgunData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"ConfgId : {v.ConfgNameId}{Environment.NewLine}";
                    sAns += $"AmmoTypeId : {v.AmmoTypeId}{Environment.NewLine}";
                    sAns += $"CaliberId : {v.CaliberId}{Environment.NewLine}";
                    sAns += $"ShotWeight : {v.ShotWeight}{Environment.NewLine}";
                    sAns += $"PrimerId : {v.PrimerId}{Environment.NewLine}";
                    sAns += $"CaseId : {v.CaseId}{Environment.NewLine}";
                    sAns += $"ShotWeightText : {v.ShotWeightText}{Environment.NewLine}";
                    sAns += $"Bushing : {v.Bushing}{Environment.NewLine}";
                    sAns += $"Wad : {v.Wad}{Environment.NewLine}";
                    sAns += $"ShotChargeLoad : {v.ShotChargeLoad}{Environment.NewLine}";
                    sAns += $"Source : {v.Source}{Environment.NewLine}";
                    sAns += $"GunId : {v.GunId}{Environment.NewLine}";
                    sAns += $"IsPersonal : {v.IsPersonal}{Environment.NewLine}";
                    sAns += $"ListTypeId : {v.ListTypeId}{Environment.NewLine}";
                    sAns += $"BushingId : {v.BushingId}{Environment.NewLine}";
                    sAns += $"ChargeBarId : {v.ChargeBarId}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }

        /// <summary>
        /// Configurations the name list data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ConfigNameListData(List<ConfigNameList> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ConfigNameList v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"IsPersonal : {v.IsPersonal}{Environment.NewLine}";
                    sAns += $"IsShotGun : {v.IsShotGun}{Environment.NewLine}";
                    sAns += $"Notes : {v.Notes}{Environment.NewLine}";
                    sAns += $"IsActive : {v.IsActive}{Environment.NewLine}";
                    sAns += $"IsFavorite : {v.IsFavorite}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Configurations the list powder data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ConfigListPowderDataData(List<ConfigListPowderData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ConfigListPowderData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"ConfigId : {v.ConfigId}{Environment.NewLine}";
                    sAns += $"PowderId : {v.PowderId}{Environment.NewLine}";
                    sAns += $"LoadMin : {v.LoadMin}{Environment.NewLine}";
                    sAns += $"LoadMid : {v.LoadMid}{Environment.NewLine}";
                    sAns += $"LoadMax : {v.LoadMax}{Environment.NewLine}";
                    if (v.FpsMin != null) sAns += $"FpsMin : {v.FpsMin}{Environment.NewLine}";
                    if (v.FpsMid != null) sAns += $"FpsMid : {v.FpsMid}{Environment.NewLine}";
                    if (v.FpsMax != null) sAns += $"FpsMax : {v.FpsMax}{Environment.NewLine}";
                    if (v.CupsMin != null) sAns += $"CupsMin : {v.CupsMin}{Environment.NewLine}";
                    if (v.CupsMid != null) sAns += $"CupsMid : {v.CupsMid}{Environment.NewLine}";
                    if (v.CupsMax != null) sAns += $"CupsMax : {v.CupsMax}{Environment.NewLine}";
                    if (v.PsiMin != null) sAns += $"PsiMin : {v.PsiMin}{Environment.NewLine}";
                    if (v.PsiMid != null) sAns += $"PsiMid : {v.PsiMid}{Environment.NewLine}";
                    if (v.PsiMax != null) sAns += $"PsiMax : {v.PsiMax}{Environment.NewLine}";
                    if (v.LupMin != null) sAns += $"LupMin : {v.LupMin}{Environment.NewLine}";
                    if (v.LupMid != null) sAns += $"LupMid : {v.LupMid}{Environment.NewLine}";
                    if (v.LupMax != null) sAns += $"LupMax : {v.LupMax}{Environment.NewLine}";
                    sAns += $"IsDefault : {v.IsDefault}{Environment.NewLine}";
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
        /// <summary>
        /// Calibers the lists data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string CaliberListsData(List<CaliberLists> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (CaliberLists v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Caliber : {v.Caliber}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Ammuntions the type listings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string AmmuntionTypeListingsData(List<AmmuntionTypeListings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (AmmuntionTypeListings v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"FirearmType : {v.FirearmType}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Cases the listings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string CaseListingsData(List<CaseListings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (CaseListings v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"TrimToLength : {v.TrimToLength}{Environment.NewLine}";
                    sAns += $"IsNew : {v.IsNew}{Environment.NewLine}";
                    sAns += $"TimesUsed : {v.TimesUsed}{Environment.NewLine}";
                    sAns += $"Qty : {v.Qty}{Environment.NewLine}";
                    sAns += $"Price : {v.Price}{Environment.NewLine}";
                    sAns += $"CaliberId : {v.CaliberId}{Environment.NewLine}";
                    sAns += $"EstimatedPricePerCase : {v.EstimatedPricePerCase}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Equipments the lists data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string EquipmentListsData(List<EquipmentLists> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (EquipmentLists v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"Use : {v.Use}{Environment.NewLine}";
                    sAns += $"Cost : {v.Cost}{Environment.NewLine}";
                    sAns += $"Notes : {v.Notes}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Powders the listing data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string PowderListingData(List<PowderListing> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (PowderListing v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"WeightInPounds : {v.WeightInPounds}{Environment.NewLine}";
                    sAns += $"WeightInGrains : {v.WeightInGrains}{Environment.NewLine}";
                    sAns += $"Price : {v.Price}{Environment.NewLine}";
                    sAns += $"Notes : {v.Notes}{Environment.NewLine}";
                    sAns += $"PricePerGrain : {v.PricePerGrain}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }

        /// <summary>
        /// Shotguns the bushing listings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ShotgunBushingListingsData(List<ShotgunBushingListings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ShotgunBushingListings v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"TrimToLength : {v.Charge}{Environment.NewLine}";
                    sAns += $"ForPowder : {v.ForPowder}{Environment.NewLine}";
                    sAns += $"ForShot : {v.ForShot}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
    }
}
