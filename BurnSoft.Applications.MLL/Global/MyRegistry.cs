using BurnSoft.Applications.MLL.Types;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
// ReSharper disable PossibleNullReferenceException
// ReSharper disable RedundantAssignment
// ReSharper disable TooWideLocalVariableScope
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToNullCoalescingExpression

// ReSharper disable UnusedMember.Local
// ReSharper disable ConvertToAutoProperty

namespace BurnSoft.Applications.MLL.Global
{
    /// <summary>
    /// Class MyRegistry. General Registry class for the My Loaders Log Application to read, setups, and write
    /// </summary>
    public class MyRegistry
    {

        #region "Exception Error Handling"        
        /// <summary>
        /// The class location
        /// </summary>
        private static string _classLocation = "BurnSoft.Applications.MLL.Global.MyRegistry";
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
        //End Snippet        
        /// <summary>
        /// The reg path
        /// </summary>
        private static string _regPath;
        /// <summary>
        /// The reg successful
        /// </summary>
        private static string _regSuccessful;
        /// <summary>
        /// The reg set hist listtb
        /// </summary>
        private static string _regSetHistListtb;
        /// <summary>
        /// The reg set hist listdt
        /// </summary>
        private static string _regSetHistListdt;
        /// <summary>
        /// The reg alert on back up
        /// </summary>
        private static bool _regAlertOnBackUp = true;
        /// <summary>
        /// The reg track history days
        /// </summary>
        private static int _regTrackHistoryDays;
        /// <summary>
        /// The reg last path
        /// </summary>
        private static string _regLastPath;
        /// <summary>
        /// The reg last file
        /// </summary>
        private static string _regLastFile;
        /// <summary>
        /// The reg backup on exit
        /// </summary>
        private static bool _regBackupOnExit;
        /// <summary>
        /// The reg use org image
        /// </summary>
        private static bool _regUseOrgImage;
        /// <summary>
        /// The loadertype shotgun
        /// </summary>
        private static bool _loadertypeShotgun = false;
        /// <summary>
        /// The view FPS
        /// </summary>
        private static bool _viewFps = true;
        /// <summary>
        /// The view cups
        /// </summary>
        private static bool _viewCups = true;
        /// <summary>
        /// The loadertype non shotgun
        /// </summary>
        private static bool _loadertypeNonShotgun = true;
        /// <summary>
        /// The default list
        /// </summary>
        private static string _defaultList;

        /// <summary>
        /// The reg indv reports
        /// </summary>
        private static bool _regIndvReports = true;
        /// <summary>
        /// The reg track history
        /// </summary>
        private static bool _regTrackHistory = true;
        /// <summary>
        /// The reg number format
        /// </summary>
        private static string _regNumberFormat;
        /// <summary>
        /// The reg automatic update
        /// </summary>
        private static bool _regAutoUpdate;
        /// <summary>
        /// The reg use proxy
        /// </summary>
        private static bool _regUseProxy;
        /// <summary>
        /// The reg use number cat only
        /// </summary>
        private static bool _regUseNumberCatOnly;
        /// <summary>
        /// The reg auditammo
        /// </summary>
        private static bool _regAuditammo;
        /// <summary>
        /// The reg useautoassign
        /// </summary>
        private static bool _regUseautoassign;
        /// <summary>
        /// The reg uniquecustcatid/
        /// </summary>
        private static bool _regUniquecustcatid;
        /// <summary>
        /// The reg useselectiveboundbook
        /// </summary>
        private static bool _regUseselectiveboundbook;
        /// <summary>
        /// Gets or sets the default reg path.
        /// </summary>
        /// <value>The default reg path.</value>
        public static string DefaultRegPath
        {
            get
            {
                if (_regPath == null)
                {
                    _regPath = @"Software\\BurnSoft\\BSMLL";
                    return _regPath;
                }
                if (_regPath.Length == 0)
                    _regPath = @"Software\\BurnSoft\\BSMLL";
                return _regPath;
            }
            set => _regPath = value;
        }
        /// <summary>
        /// Gets or sets the reg successful.
        /// </summary>
        /// <value>The reg successful.</value>
        private static string RegSuccessful
        {
            get
            {
                if (_regSuccessful == null)
                {
                    _regSuccessful = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                    return _regSuccessful;
                }
                if (_regSuccessful.Length == 0)
                    _regSuccessful = DateTime.Now.ToString(CultureInfo.InvariantCulture);
                return _regSuccessful;
            }
            set => _regSuccessful = value;
        }
        /// <summary>
        /// Gets or sets the reg set hist listtb.
        /// </summary>
        /// <value>The reg set hist listtb.</value>
        private static string RegSetHistListtb
        {
            get => _regSetHistListtb;
            set => _regSetHistListtb = value;
        }
        /// <summary>
        /// Gets or sets the reg set hist listdt.
        /// </summary>
        /// <value>The reg set hist listdt.</value>
        private static string RegSetHistListdt
        {
            get => _regSetHistListdt;
            set => _regSetHistListdt = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg alert on back up].
        /// </summary>
        /// <value><c>true</c> if [reg alert on back up]; otherwise, <c>false</c>.</value>
        private static bool RegAlertOnBackUp
        {
            get => _regAlertOnBackUp;
            set => _regAlertOnBackUp = value;
        }
        /// <summary>
        /// Gets or sets the reg track history days.
        /// </summary>
        /// <value>The reg track history days.</value>
        private static int RegTrackHistoryDays
        {
            get
            {
                if (_regTrackHistoryDays == 0)
                    _regTrackHistoryDays = 15;
                return _regTrackHistoryDays;
            }
            set => _regTrackHistoryDays = value;
        }
        /// <summary>
        /// Gets or sets the reg last path.
        /// </summary>
        /// <value>The reg last path.</value>
        private static string RegLastPath
        {
            get
            {
                if (_regLastPath == null)
                {
                    _regLastPath = @"C:\";
                    return _regLastPath;
                }
                if (_regLastPath.Length == 0)
                    _regLastPath = @"C:\";
                return _regLastPath;
            }
            set => _regLastPath = value;
        }
        /// <summary>
        /// Gets or sets the reg last file.
        /// </summary>
        /// <value>The reg last file.</value>
        private static string RegLastFile
        {
            get
            {
                if (_regLastFile == null)
                {
                    _regLastFile = "MLL.MDB";
                    return _regLastFile;
                }
                if (_regLastFile.Length == 0)
                    _regLastFile = "MLL.MDB";
                return _regLastFile;
            }
            set => _regLastFile = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg backup on exit].
        /// </summary>
        /// <value><c>true</c> if [reg backup on exit]; otherwise, <c>false</c>.</value>
        private static bool RegBackupOnExit
        {
            get => _regBackupOnExit;
            set => _regBackupOnExit = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg use org image].
        /// </summary>
        /// <value><c>true</c> if [reg use org image]; otherwise, <c>false</c>.</value>
        private static bool RegUseOrgImage
        {
            get => _regUseOrgImage;
            set => _regUseOrgImage = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [loadertype shotgun].
        /// </summary>
        /// <value><c>true</c> if [loadertype shotgun]; otherwise, <c>false</c>.</value>
        private static bool LoadertypeShotgun
        {
            get => _loadertypeShotgun;
            set => _loadertypeShotgun = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [loader type non shotgun].
        /// </summary>
        /// <value><c>true</c> if [loader type non shotgun]; otherwise, <c>false</c>.</value>
        private static bool LoaderTypeNonShotgun
        {
            get => _loadertypeNonShotgun;
            set => _loadertypeNonShotgun = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [view FPS].
        /// </summary>
        /// <value><c>true</c> if [view FPS]; otherwise, <c>false</c>.</value>
        private static bool ViewFps
        {
            get => _viewFps;
            set => _viewFps = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [view cups].
        /// </summary>
        /// <value><c>true</c> if [view cups]; otherwise, <c>false</c>.</value>
        private static bool ViewCups
        {
            get => _viewCups;
            set => _viewCups = value;
        }
        /// <summary>
        /// Gets or sets the default list.
        /// </summary>
        /// <value>The default list.</value>
        private static string DefaultList
        {
            get => _defaultList;
            set => _defaultList = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg indv reports].
        /// </summary>
        /// <value><c>true</c> if [reg indv reports]; otherwise, <c>false</c>.</value>
        private static bool RegIndvReports
        {
            get => _regIndvReports;
            set => _regIndvReports = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg track history].
        /// </summary>
        /// <value><c>true</c> if [reg track history]; otherwise, <c>false</c>.</value>
        private static bool RegTrackHistory
        {
            get => _regTrackHistory;
            set => _regTrackHistory = value;
        }
        /// <summary>
        /// Gets or sets the reg number format.
        /// </summary>
        /// <value>The reg number format.</value>
        private static string RegNumberFormat
        {
            get
            {
                if (_regNumberFormat == null)
                {
                    _regNumberFormat = "0000";
                    return _regNumberFormat;
                }
                if (_regNumberFormat.Length == 0)
                    _regNumberFormat = "0000";
                return _regNumberFormat;
            }
            set => _regNumberFormat = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg automatic update].
        /// </summary>
        /// <value><c>true</c> if [reg automatic update]; otherwise, <c>false</c>.</value>
        private static bool RegAutoUpdate
        {
            get => _regAutoUpdate;
            set => _regAutoUpdate = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg use proxy].
        /// </summary>
        /// <value><c>true</c> if [reg use proxy]; otherwise, <c>false</c>.</value>
        private static bool RegUseProxy
        {
            get => _regUseProxy;
            set => _regUseProxy = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg auditammo].
        /// </summary>
        /// <value><c>true</c> if [reg auditammo]; otherwise, <c>false</c>.</value>
        private static bool RegAuditammo
        {
            get => _regAuditammo;
            set => _regAuditammo = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg use number cat only].
        /// </summary>
        /// <value><c>true</c> if [reg use number cat only]; otherwise, <c>false</c>.</value>
        private static bool RegUseNumberCatOnly
        {
            get => _regUseNumberCatOnly;
            set => _regUseNumberCatOnly = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg useautoassign].
        /// </summary>
        /// <value><c>true</c> if [reg useautoassign]; otherwise, <c>false</c>.</value>
        private static bool RegUseautoassign
        {
            get => _regUseautoassign;
            set => _regUseautoassign = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg uniquecustcatid].
        /// </summary>
        /// <value><c>true</c> if [reg uniquecustcatid]; otherwise, <c>false</c>.</value>
        private static bool RegUniquecustcatid
        {
            get => _regUniquecustcatid;
            set => _regUniquecustcatid = value;
        }
        /// <summary>
        /// Gets or sets a value indicating whether [reg useselectiveboundbook].
        /// </summary>
        /// <value><c>true</c> if [reg useselectiveboundbook]; otherwise, <c>false</c>.</value>
        private static bool RegUseselectiveboundbook
        {
            get => _regUseselectiveboundbook;
            set => _regUseselectiveboundbook = value;
        }
        /// <summary>
        /// Creates the sub key.
        /// </summary>
        /// <param name="strValue">The string value.</param>
        /// <param name="errOut">The error out.</param>
        public static void CreateSubKey(string strValue, out string errOut)
        {
            errOut = "";
            try
            {
                Registry.CurrentUser.CreateSubKey(strValue);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("CreateSubKey", e);
            }
        }
        /// <summary>
        /// Ups the date application details.
        /// </summary>
        /// <param name="productVersion">The product version.</param>
        /// <param name="productName">Name of the product.</param>
        /// <param name="executablePath">The executable path.</param>
        /// <param name="appPath">The application path.</param>
        /// <param name="logFile">The log file.</param>
        /// <param name="databasePath">The database path.</param>
        /// <param name="appDataPath">The application data path.</param>
        /// <param name="errOut">The error out.</param>
        public static bool UpdateAppDetails(string productVersion, string productName, string executablePath, 
            string appPath, string logFile, string databasePath, string appDataPath, out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                string strValue = DefaultRegPath;
                if (!RegSubKeyExists(strValue, out errOut))
                    CreateSubKey(strValue, out errOut);

                RegistryKey myReg = Registry.CurrentUser.OpenSubKey(strValue, true);
                myReg.SetValue("Version", productVersion);
                myReg.SetValue("AppName", productName);
                myReg.SetValue("AppEXE", executablePath);
                myReg.SetValue("Path", appPath);
                myReg.SetValue("LogPath", logFile);
                myReg.SetValue("DataBase", databasePath);
                myReg.SetValue("AppDataPath", appDataPath);
                myReg.Close();
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("UpDateAppDetails", e);
            }

            return bAns;
        }
        /// <summary>
        /// Regs the sub key exists.
        /// </summary>
        /// <param name="strValue">The string value.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool RegSubKeyExists(string strValue, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                RegistryKey myReg = Registry.CurrentUser.OpenSubKey(strValue, true);
                if (myReg != null) bAns = true;
            }
            catch (Exception ex)
            {
                errOut = ErrorMessage("RegSubKeyExists", ex);
            }
            return bAns;
        }
        /// <summary>
        /// Gets the reg sub key value.
        /// </summary>
        /// <param name="strKey">The string key.</param>
        /// <param name="strValue">The string value.</param>
        /// <param name="strDefault">The string default.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        public static string GetRegSubKeyValue(string strKey, string strValue, string strDefault, out string errOut)
        {
            string sAns;
#pragma warning disable 219
            string strMsg = "";
#pragma warning restore 219
            errOut = "";
            RegistryKey myReg;
            try
            {
                if (RegSubKeyExists(strKey, out errOut))
                {
                    myReg = Registry.CurrentUser.OpenSubKey(strKey, true);

                    var checkValueExists = myReg.GetValue(strValue);
                    if (checkValueExists == null)
                    {
                        myReg.SetValue(strValue, strDefault);
                        sAns = strDefault;
                    }
                    if (myReg.GetValue(strValue).ToString().Length > 0)
                        sAns = myReg.GetValue(strValue).ToString();
                    else
                    {
                        myReg.SetValue(strValue, strDefault);
                        sAns = strDefault;
                    }
                }
                else
                {
                    CreateSubKey(strKey, out errOut);
                    myReg = Registry.CurrentUser.OpenSubKey(strKey, true);
                    myReg.SetValue(strValue, strDefault);
                    sAns = strDefault;
                }
            }
            catch (Exception ex)
            {
                sAns = strDefault;
                errOut = ErrorMessage("GetRegSubKeyValue", ex);
            }
            return sAns;
        }
        /// <summary>
        /// Sets the setting details.
        /// </summary>
        public static bool SetSettingDetails(out string errOut)
        {
            errOut = "";
            bool bAns = false;
            try
            {
                if (!SettingsExists(out errOut))
                {
                    string strValue = DefaultRegPath + @"\Settings";
                    RegistryKey myReg = Registry.CurrentUser.OpenSubKey(strValue, true);
                    myReg = Registry.CurrentUser.CreateSubKey(strValue);
                    List<RegistrySettings> reg = BuildRegistry();
                    if (!SaveSettings(reg, out errOut)) throw new Exception(errOut);
                }
                if (errOut.Length > 0) throw new Exception(errOut);
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SetSettingDetails", e);
            }

            return bAns;
        }
        
        /// <summary>
        /// Settingses the exists.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool SettingsExists(out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                string strValue = DefaultRegPath + @"\Settings";
                RegistryKey myReg = Registry.CurrentUser.OpenSubKey(strValue, true);
                if (myReg != null) bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SettingsExists", e);
            }
            return bAns;
        }
        /// <summary>
        /// Gets the settings.
        /// </summary>
        /// <param name="errOut">The error out.</param>
        /// <returns>List&lt;RegistrySettings&gt;.</returns>
        public static List<RegistrySettings> GetSettings(out string errOut)
        {
            errOut = "";
            List<RegistrySettings> lst = new List<RegistrySettings>();
            RegistryKey myReg;
            string strValue = DefaultRegPath + @"\Settings";
            try
            {
                int TrackHistoryDays = 15;
                bool TrackHistory = false;
                string NumberFormat = "0000";  // TODO This registry settings is no longer needed
                bool AutoUpdate = false;
                bool UseProxy = false;
                string Successful = DateTime.Now.ToString();
                bool AlertOnBackUp = false;
                bool BackupOnExit = false;
                bool UseOrgImage = true;
                bool LOADERTYPE_SHOTGUN = false;
                bool LOADERTYPE_NONSHOTGUN = true;
                bool VIEW_FPS = true;
                bool VIEW_CUPS = true;
                string DefaultList = "Caliber List";
                bool IndvReports = true;
                string ConfigSort = "All";

                lst.Add(new RegistrySettings()
                {
                    TrackHistoryDays = Convert.ToInt32(GetRegSubKeyValue(strValue, "TrackHistoryDays", TrackHistoryDays.ToString(), out _)),
                    TrackHistory = Convert.ToBoolean(GetRegSubKeyValue(strValue, "TrackHistory", TrackHistory.ToString(), out _)),
                    NumberFormat = GetRegSubKeyValue(strValue, "NumberFormat", NumberFormat, out errOut),
                    LastSucBackup = GetRegSubKeyValue(strValue, "Successful", Successful, out errOut),
                    AutoUpdate = Convert.ToBoolean(GetRegSubKeyValue(strValue, "AutoUpdate", AutoUpdate.ToString(), out _)),
                    UseProxy = Convert.ToBoolean(GetRegSubKeyValue(strValue, "UseProxy", UseProxy.ToString(), out _)),
                    AlertOnBackUp = Convert.ToBoolean(GetRegSubKeyValue(strValue, "AlertOnBackUp", AlertOnBackUp.ToString(), out _)),
                    BackupOnExit = Convert.ToBoolean(GetRegSubKeyValue(strValue, "BackupOnExit", BackupOnExit.ToString(), out _)),
                    UseOrgImage = Convert.ToBoolean(GetRegSubKeyValue(strValue, "UseOrgImage", UseOrgImage.ToString(), out _)),
                    LoaderTypeShotGun = Convert.ToBoolean(GetRegSubKeyValue(strValue, "LOADERTYPE_SHOTGUN", LOADERTYPE_SHOTGUN.ToString(), out _)),
                    LoaderTypeMetalic = Convert.ToBoolean(GetRegSubKeyValue(strValue, "LOADERTYPE_NONSHOTGUN", LOADERTYPE_NONSHOTGUN.ToString(), out _)),
                    ViewFps = Convert.ToBoolean(GetRegSubKeyValue(strValue, "VIEW_FPS", VIEW_FPS.ToString(), out _)),
                    ViewCups = Convert.ToBoolean(GetRegSubKeyValue(strValue, "VIEW_CUPS", VIEW_CUPS.ToString(), out _)),
                    DefaultList = GetRegSubKeyValue(strValue, "DefaultList", DefaultList, out errOut),
                    ConfigSort = GetRegSubKeyValue(strValue, "ConfigSort", ConfigSort, out errOut),
                    IndvReports = Convert.ToBoolean(GetRegSubKeyValue(strValue, "VIEW_CUPS", IndvReports.ToString(), out _)),
                });

            }
            catch (Exception ex)
            {
                errOut = ErrorMessage("GetSettings", ex);
                //TODO IF ERROR CREATE KEYS IF THEY DON"T EXIST
                //SetSettingDetails();
            }
            return lst;
        }

        /// <summary>
        /// Builds the registry list string to use for saving
        /// </summary>
        /// <param name="AutoUpdate">if set to <c>true</c> [automatic update].</param>
        /// <param name="UseProxy">if set to <c>true</c> [use proxy].</param>
        /// <param name="Successful">The successful.</param>
        /// <param name="AlertOnBackUp">if set to <c>true</c> [alert on back up].</param>
        /// <param name="BackupOnExit">if set to <c>true</c> [backup on exit].</param>
        /// <param name="UseOrgImage">if set to <c>true</c> [use org image].</param>
        /// <param name="LOADERTYPE_SHOTGUN">if set to <c>true</c> [loadertype shotgun].</param>
        /// <param name="LOADERTYPE_NONSHOTGUN">if set to <c>true</c> [loadertype nonshotgun].</param>
        /// <param name="VIEW_FPS">if set to <c>true</c> [view FPS].</param>
        /// <param name="IndvReports">if set to <c>true</c> [indv reports].</param>
        /// <param name="VIEW_CUPS">if set to <c>true</c> [view cups].</param>
        /// <param name="DefaultList">The default list.</param>
        /// <param name="ConfigSort">The configuration sort.</param>
        /// <param name="TrackHistoryDays">The track history days.</param>
        /// <param name="TrackHistory">if set to <c>true</c> [track history].</param>
        /// <returns>List&lt;RegistrySettings&gt;.</returns>
        public static List<RegistrySettings> BuildRegistry(bool AutoUpdate = false, bool UseProxy = false, 
            string Successful = "", bool AlertOnBackUp = false, bool BackupOnExit = false, bool UseOrgImage = true, 
            bool LOADERTYPE_SHOTGUN = false, bool LOADERTYPE_NONSHOTGUN = true, bool VIEW_FPS = true,
            bool IndvReports = true, bool VIEW_CUPS = true, string DefaultList = "Caliber List", 
            string ConfigSort = "All", int TrackHistoryDays = 15, bool TrackHistory = false)
        {
            List<RegistrySettings> lst = new List<RegistrySettings>();
            string errOut = "";
            try
            {
                Successful = Successful.Length == 0 ? DateTime.Now.ToString() : Successful;
                string NumberFormat = "0000";

                lst.Add(new RegistrySettings()
                {
                    TrackHistoryDays = TrackHistoryDays,
                    TrackHistory = TrackHistory,
                    NumberFormat = NumberFormat,
                    LastSucBackup = Successful,
                    AutoUpdate = AutoUpdate,
                    UseProxy = UseProxy,
                    AlertOnBackUp = AlertOnBackUp,
                    BackupOnExit = BackupOnExit,
                    UseOrgImage = UseOrgImage,
                    LoaderTypeShotGun = LOADERTYPE_SHOTGUN,
                    LoaderTypeMetalic = LOADERTYPE_NONSHOTGUN,
                    ViewFps = VIEW_FPS,
                    ViewCups = VIEW_CUPS,
                    DefaultList = DefaultList,
                    ConfigSort = ConfigSort,
                    IndvReports = IndvReports,
                });
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("BuildRegistry", e);
            }
            return lst;
        }

        /// <summary>
        /// Saves the settings.
        /// </summary>
        /// <param name="settings">The settings.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool SaveSettings(List<RegistrySettings> settings, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                if (settings.Count > 0)
                {
                    string strValue = DefaultRegPath + @"\Settings";
                    RegistryKey myReg = Registry.CurrentUser.OpenSubKey(strValue, true);
                    if (myReg == null)
                        myReg = Registry.CurrentUser.CreateSubKey(strValue);
                    foreach (RegistrySettings s in settings)
                    {
                        myReg.SetValue("TrackHistoryDays", s.TrackHistoryDays);
                        myReg.SetValue("TrackHistory", s.TrackHistory);
                        myReg.SetValue("NumberFormat", s.NumberFormat);
                        myReg.SetValue("AutoUpdate", s.AutoUpdate);
                        myReg.SetValue("AlertOnBackUp", s.AlertOnBackUp);
                        myReg.SetValue("BackupOnExit", s.BackupOnExit);
                        myReg.SetValue("UseOrgImage", s.UseOrgImage);
                        myReg.SetValue("LOADERTYPE_SHOTGUN", s.LoaderTypeShotGun);
                        myReg.SetValue("IndvReports", s.IndvReports);
                        myReg.SetValue("LOADERTYPE_NONSHOTGUN", s.LoaderTypeMetalic);
                        myReg.SetValue("DefaultList", s.DefaultList);
                        myReg.SetValue("VIEW_FPS", s.ViewFps);
                        myReg.SetValue("VIEW_CUPS", s.ViewCups);
                        myReg.Close();
                    }

                }
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SaveSettings", e);
            }

            return bAns;
        }
        
        /// <summary>
        /// Saves the last working dir.
        /// </summary>
        /// <param name="strPath">The string path.</param>
        /// <param name="errOut">The error out.</param>
        public static bool SaveLastWorkingDir(string strPath, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                string strValue = DefaultRegPath + @"\Settings";
                RegistryKey myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default);
                if (myReg == null)
                    myReg = Registry.CurrentUser.CreateSubKey(strValue);
                myReg.SetValue("LastWorkingPath", strPath);
                myReg.Close();
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SaveLastWorkingDir", e);
            }

            return bAns;
        }

        /// <summary>
        /// Sets the hot fix.
        /// </summary>
        /// <param name="hotfixNumber">The hotfix number.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="installNotice">The Date and Time it was installed, OnInstall will skip the reinstall since that is by current version.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool SetHotFix(int hotfixNumber, out string errOut, string installNotice = "OnInstall")
        {
            bool bAns = false;
            errOut = "";
            try
            {
                string strValue = DefaultRegPath + @"\HotFix";
                RegistryKey myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default);
                if (myReg == null)
                    myReg = Registry.CurrentUser.CreateSubKey(strValue);
                myReg.SetValue($"{hotfixNumber}", installNotice);
                myReg.Close();
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SetHotFix", e);
            }

            return bAns;
        }

        /// <summary>
        /// Sets the setting value.
        /// </summary>
        /// <param name="subKey">Name of the sub key with the default to the Main Application Path, if left blank it will insert in root </param>
        /// <param name="name">name to store the value in the key</param>
        /// <param name="value">The value.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool SetValue(string subKey, string name, string value, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                string strValue = DefaultRegPath;
                if (subKey.Length > 0) strValue = DefaultRegPath + $"\\{subKey}";
                RegistryKey myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default);
                if (myReg == null)
                    myReg = Registry.CurrentUser.CreateSubKey(strValue);
                myReg.SetValue(name, value);
                myReg.Close();
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SetValue", e);
            }

            return bAns;
        }
        /// <summary>
        /// Saves the view settings.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool SaveViewSettings(string key, string value, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                string strValue = $"{DefaultRegPath}\\Settings";
                RegistryKey myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default);
                if (myReg == null)
                    myReg = Registry.CurrentUser.CreateSubKey(strValue);
                myReg.SetValue(key, value);
                myReg.Close();
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SaveViewSettings", e);
            }
            return bAns;
        }

        /// <summary>
        /// Saves the configuration sort.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool SaveConfigSort(string value, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                string strValue = $"{DefaultRegPath}\\Settings";
                RegistryKey myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default);
                if (myReg == null)
                    myReg = Registry.CurrentUser.CreateSubKey(strValue);
                myReg.SetValue("ConfigSort", value);
                myReg.Close();
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SaveConfigSort", e);
            }
            return bAns;
        }
        /// <summary>
        /// Sets the last update.
        /// </summary>
        /// <param name="hotfixNumber">The hotfix number.</param>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool SetLastUpdate(int hotfixNumber, out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                string strValue = DefaultRegPath + @"\HotFix";
                RegistryKey myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default);
                if (myReg == null)
                    myReg = Registry.CurrentUser.CreateSubKey(strValue);
                myReg.SetValue("LastUpdate", $"{hotfixNumber}");
                myReg.Close();
                bAns = true;
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("SetLastUpdate", e);
            }

            return bAns;
        }
        /// <summary>
        /// Gets the last working dir.
        /// </summary>
        /// <param name="errOut">The error out.</param>
        /// <returns>System.String.</returns>
        public static string GetLastWorkingDir(out string errOut)
        {
            string sAns = "";
            errOut = "";
            try
            {
                string strValue = DefaultRegPath + @"\Settings";
                RegistryKey myReg = Registry.CurrentUser.CreateSubKey(strValue, RegistryKeyPermissionCheck.Default);
                if (myReg == null)
                {
                    myReg = Registry.CurrentUser.CreateSubKey(strValue);
                    myReg.SetValue("LastWorkingPath", "");
                }
                sAns = myReg.GetValue("LastWorkingPath", "").ToString();
                myReg.Close();
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetLastWorkingDir", e);
            }
            return sAns;
        }
        /// <summary>
        /// Gets the view settings.
        /// </summary>
        /// <param name="sKey">The s key.</param>
        /// <param name="errOut">The error out.</param>
        /// <param name="sDefault">The s default.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        public static string GetViewSettings(string sKey, out string errOut, string sDefault = "")
        {
            string sAns = "";
            errOut = "";
            try
            {
                string strValue = DefaultRegPath + @"\Settings";
                sAns = GetRegSubKeyValue(strValue, sKey, sDefault, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetViewSettings", e);
            }
            return sAns;
        }
        /// <summary>
        /// Gets the database location.
        /// </summary>
        /// <param name="errOut">The error out.</param>
        /// <param name="sDefault">The s default.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        public static string GetDatabaseLocation(out string errOut, string sDefault = "")
        {
            string sAns = "";
            errOut = "";
            try
            {
                sAns = GetRegSubKeyValue(DefaultRegPath, "DataBase", sDefault, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetDatabaseLocation", e);
            }
            return sAns;
        }

        /// <summary>
        /// Gets the executable path.
        /// </summary>
        /// <param name="errOut">The error out.</param>
        /// <param name="sDefault">The s default.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.Exception"></exception>
        public static string GetExePath(out string errOut, string sDefault = "")
        {
            string sAns = "";
            errOut = "";
            try
            {
                sAns = GetRegSubKeyValue(DefaultRegPath, "AppEXE", sDefault, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("GetMgcExePath", e);
            }
            return sAns;
        }
        /// <summary>
        /// Checks to see if the gun collection is installed.
        /// </summary>
        /// <param name="errOut">The error out.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="System.Exception"></exception>
        public static bool MyGunCollectionIsInstalled(out string errOut)
        {
            bool bAns = false;
            errOut = "";
            try
            {
                bAns = RegSubKeyExists(DefaultRegPath, out errOut);
                if (errOut.Length > 0) throw new Exception(errOut);
            }
            catch (Exception e)
            {
                errOut = ErrorMessage("MyGunCollectionIsInstalled", e);
            }
            return bAns;
        }

    }
}
