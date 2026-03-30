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
        /// Synchronizes the tables data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string SyncTablesDataData(List<SyncTablesData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (SyncTablesData p in value)
                {
                    sAns += $"Id : {p.Id}{Environment.NewLine}";
                    sAns += $"TableName : {p.TableName}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Wishlists the data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string WishlistDataData(List<WishlistData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (WishlistData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Model : {v.Model}{Environment.NewLine}";
                    sAns += $"PlaceToBuy : {v.PlaceToBuy}{Environment.NewLine}";
                    sAns += $"Qty : {v.Qty}{Environment.NewLine}";
                    sAns += $"Value : {v.Value}{Environment.NewLine}";
                    sAns += $"Notes : {v.Notes}{Environment.NewLine}";
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
        /// Loaderses the log metallic data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LoadersLogMetallicDataData(List<LoadersLogMetallicData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (LoadersLogMetallicData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"FirearmId : {v.FirearmId}{Environment.NewLine}";
                    sAns += $"DateCreated : {v.DateCreated}{Environment.NewLine}";
                    sAns += $"Yards : {v.Yards}{Environment.NewLine}";
                    sAns += $"GroupSize : {v.GroupSize}{Environment.NewLine}";
                    sAns += $"NumberOfShots : {v.NumberOfShots}{Environment.NewLine}";
                    sAns += $"PowderDetails : {v.PowderDetails}{Environment.NewLine}";
                    sAns += $"BulletDetails : {v.BulletDetails}{Environment.NewLine}";
                    sAns += $"PrimerDetails : {v.PrimerDetails}{Environment.NewLine}";
                    sAns += $"CaseDetails : {v.CaseDetails}{Environment.NewLine}";
                    sAns += $"TotalLenght : {v.TotalLenght}{Environment.NewLine}";
                    sAns += $"Conditions : {v.Conditions}{Environment.NewLine}";
                    sAns += $"ConfigName : {v.ConfigName}{Environment.NewLine}";
                    sAns += $"Caliber : {v.Caliber}{Environment.NewLine}";
                    sAns += $"FirearmName : {v.FirearmName}{Environment.NewLine}";
                    sAns += $"BarrelLength : {v.BarrelLength}{Environment.NewLine}";
                    sAns += $"Notes : {v.Notes}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Loaderses the log shotgun data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LoadersLogShotgunDataData(List<LoadersLogShotgunData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (LoadersLogShotgunData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"FirearmId : {v.FirearmId}{Environment.NewLine}";
                    sAns += $"DateCreated : {v.DateCreated}{Environment.NewLine}";
                    sAns += $"Yards : {v.Yards}{Environment.NewLine}";
                    sAns += $"Caliber : {v.Caliber}{Environment.NewLine}";
                    sAns += $"FirearmName : {v.FirearmName}{Environment.NewLine}";
                    sAns += $"PowderDetails : {v.PowderDetails}{Environment.NewLine}";
                    sAns += $"BarrelLength : {v.BarrelLength}{Environment.NewLine}";
                    sAns += $"DateCreated : {v.DateCreated}{Environment.NewLine}";
                    sAns += $"ShotWeight : {v.ShotWeight}{Environment.NewLine}";
                    sAns += $"ShotSize : {v.ShotSize}{Environment.NewLine}";
                    sAns += $"WadDetails : {v.WadDetails}{Environment.NewLine}";
                    sAns += $"PowderDetails : {v.PowderDetails}{Environment.NewLine}";
                    sAns += $"CaseDetails : {v.CaseDetails}{Environment.NewLine}";
                    sAns += $"PrimerDetails : {v.PrimerDetails}{Environment.NewLine}";
                    sAns += $"PatternDensity : {v.PatternDensity}{Environment.NewLine}";
                    sAns += $"Notes : {v.Notes}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Searches the fields data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string SearchFieldsDataData(List<SearchFieldsData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (SearchFieldsData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Description : {v.Description}{Environment.NewLine}";
                    sAns += $"ColumnName : {v.ColumnName}{Environment.NewLine}";
                    sAns += $"ColumnType : {v.ColumnType}{Environment.NewLine}";
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
        /// Queries the configuration caliber metallic data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string QueryConfigCaliberMetallicDataData(List<QueryConfigCaliberData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (QueryConfigCaliberData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"IsPersonal : {v.IsPersonal}{Environment.NewLine}";
                    sAns += $"IsShotGun : {v.IsShotGun}{Environment.NewLine}";
                    sAns += $"CaliberId : {v.CaliberId}{Environment.NewLine}";
                    sAns += $"IsActive : {v.IsActive}{Environment.NewLine}";
                    sAns += $"IsFavorite : {v.IsFavorite}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Queries the configuration caliber shotgun data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string QueryConfigCaliberDataData(List<QueryConfigCaliberData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (QueryConfigCaliberData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"IsPersonal : {v.IsPersonal}{Environment.NewLine}";
                    sAns += $"IsShotGun : {v.IsShotGun}{Environment.NewLine}";
                    sAns += $"CaliberId : {v.CaliberId}{Environment.NewLine}";
                    sAns += $"IsActive : {v.IsActive}{Environment.NewLine}";
                    sAns += $"IsFavorite : {v.IsFavorite}{Environment.NewLine}";
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
                    sAns += $"BullerType : {v.BulletType}{Environment.NewLine}";
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
        /// Primers the type listings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string PrimerTypeListingsData(List<PrimerTypeListings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (PrimerTypeListings v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
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
        /// Shotguns the hull data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ShotgunHullDataData(List<ShotgunHullData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ShotgunHullData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"Gauge : {v.Gauge}{Environment.NewLine}";
                    sAns += $"GunId : {v.GunId}{Environment.NewLine}";
                    sAns += $"Length : {v.Length}{Environment.NewLine}";
                    sAns += $"Qty : {v.Qty}{Environment.NewLine}";
                    sAns += $"Price : {v.Price}{Environment.NewLine}";
                    sAns += $"DRAM : {v.DRAM}{Environment.NewLine}";
                    sAns += $"EstimatedPricePerItem : {v.EstimatedPricePerItem}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Wads the data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string WadDataData(List<WadData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (WadData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"Gauge : {v.Gauge}{Environment.NewLine}";
                    sAns += $"GaugeId : {v.GaugeId}{Environment.NewLine}";
                    sAns += $"LoadInOzText : {v.LoadInOzText}{Environment.NewLine}";
                    sAns += $"LoadInOz : {v.LoadInOz}{Environment.NewLine}";
                    sAns += $"Qty : {v.Qty}{Environment.NewLine}";
                    sAns += $"Price : {v.Price}{Environment.NewLine}";
                    sAns += $"EstimatedPricePerItem : {v.EstimatedPricePerItem}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Primers the listings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string PrimerListingsData(List<PrimerListings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (PrimerListings v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"PrimerTypeId : {v.PrimerTypeId}{Environment.NewLine}";
                    sAns += $"PrimerType : {v.PrimerType}{Environment.NewLine}";
                    sAns += $"Qty : {v.Qty}{Environment.NewLine}";
                    sAns += $"Price : {v.Price}{Environment.NewLine}";
                    sAns += $"PricePerPrimer : {v.PricePerPrimer}{Environment.NewLine}";
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
        /// Loaderses the log ammunition data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LoadersLogAmmunitionDataData(List<LoadersLogAmmunitionData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (LoadersLogAmmunitionData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"Caliber : {v.Caliber}{Environment.NewLine}";
                    sAns += $"Grain : {v.Grain}{Environment.NewLine}";
                    sAns += $"Jacket : {v.Jacket}{Environment.NewLine}";
                    sAns += $"Qty : {v.Qty}{Environment.NewLine}";
                    sAns += $"GrainDouble : {v.GrainDouble}{Environment.NewLine}";
                    sAns += $"Velocity : {v.Velocity}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Loaderses the log ammunition audit data data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string LoadersLogAmmunitionAuditDataData(List<LoadersLogAmmunitionAuditData> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (LoadersLogAmmunitionAuditData v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"ConfigId : {v.ConfigId}{Environment.NewLine}";
                    sAns += $"DateCreated : {v.DateCreated}{Environment.NewLine}";
                    sAns += $"Qty : {v.Qty}{Environment.NewLine}";
                    sAns += $"EstimatedCostToMakeTotal : {v.EstimatedCostToMakeTotal}{Environment.NewLine}";
                    sAns += $"EstimatedCostToMalePerRound : {v.EstimatedCostToMalePerRound}{Environment.NewLine}";
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
        /// <summary>
        /// Shotguns the powder listings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ShotgunPowderListingsData(List<ShotgunPowderListings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ShotgunPowderListings v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"TrimToLength : {v.Charge}{Environment.NewLine}";
                    sAns += $"Type : {v.Type}{Environment.NewLine}";
                    sAns += $"PowderName : {v.PowderName}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
        /// <summary>
        /// Shotguns the shot listings data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ShotgunShotListingsData(List<ShotgunShotListings> value)
        {
            string sAns = "";
            if (value.Count > 0)
            {
                foreach (ShotgunShotListings v in value)
                {
                    sAns += $"id : {v.Id}{Environment.NewLine}";
                    sAns += $"Manufacturer : {v.Manufacturer}{Environment.NewLine}";
                    sAns += $"Name : {v.Name}{Environment.NewLine}";
                    sAns += $"TrimToLength : {v.Charge}{Environment.NewLine}";
                    sAns += $"Type : {v.Type}{Environment.NewLine}";
                    sAns += $"LastSync : {v.LastSync}{Environment.NewLine}";
                }
            }
            return sAns;
        }
    }
}
