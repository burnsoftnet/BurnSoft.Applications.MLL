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
    }
}
