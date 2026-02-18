using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class RegistrySettings.  list container to deal with the registry settings
    /// </summary>
    public class RegistrySettings
    {
        /// <summary>
        /// Gets or sets the track history days.
        /// </summary>
        /// <value>The track history days.</value>
        public int TrackHistoryDays { get; set; }
        /// <summary>
        /// Gets or sets the last successful backup.
        /// </summary>
        /// <value>The last suc backup.</value>
        public string LastSucBackup { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [alert on back up].
        /// </summary>
        /// <value><c>true</c> if [alert on back up]; otherwise, <c>false</c>.</value>
        public bool AlertOnBackUp { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [track history].
        /// </summary>
        /// <value><c>true</c> if [track history]; otherwise, <c>false</c>.</value>
        public bool TrackHistory {  get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [automatic backup].
        /// </summary>
        /// <value><c>true</c> if [automatic backup]; otherwise, <c>false</c>.</value>
        public bool AutoBackup { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [use org image].
        /// </summary>
        /// <value><c>true</c> if [use org image]; otherwise, <c>false</c>.</value>
        public bool UseOrgImage { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [indv reports].
        /// </summary>
        /// <value><c>true</c> if [indv reports]; otherwise, <c>false</c>.</value>
        public bool IndvReports { get; set; }
        /// <summary>
        /// Gets or sets the configuration sort.
        /// </summary>
        /// <value>The configuration sort.</value>
        public string ConfigSort { get; set; }
        /// <summary>
        /// Gets or sets the number format.
        /// </summary>
        /// <value>The number format.</value>
        public string NumberFormat { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [automatic update].
        /// </summary>
        /// <value><c>true</c> if [automatic update]; otherwise, <c>false</c>.</value>
        public bool AutoUpdate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [use proxy].
        /// </summary>
        /// <value><c>true</c> if [use proxy]; otherwise, <c>false</c>.</value>
        public bool UseProxy { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [loader type shot gun].
        /// </summary>
        /// <value><c>true</c> if [loader type shot gun]; otherwise, <c>false</c>.</value>
        public bool LoaderTypeShotGun { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [loader type metalic].
        /// </summary>
        /// <value><c>true</c> if [loader type metalic]; otherwise, <c>false</c>.</value>
        public bool LoaderTypeMetalic { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [view FPS].
        /// </summary>
        /// <value><c>true</c> if [view FPS]; otherwise, <c>false</c>.</value>
        public bool ViewFps { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [view cups].
        /// </summary>
        /// <value><c>true</c> if [view cups]; otherwise, <c>false</c>.</value>
        public bool ViewCups { get; set; }
        /// <summary>
        /// Gets or sets the default list.
        /// </summary>
        /// <value>The default list.</value>
        public string DefaultList { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [backup on exit].
        /// </summary>
        /// <value><c>true</c> if [backup on exit]; otherwise, <c>false</c>.</value>
        public bool BackupOnExit { get; set; }

    }
}
