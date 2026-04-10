using System.Collections.Generic;


namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ConfigListAllShotgunData for all the shotgun data
    /// </summary>
    public class ConfigListAllShotgunData
    {
        /// <summary>
        /// Gets or sets the configuration section.
        /// </summary>
        /// <value>The configuration section.</value>
        public List<ConfigNameList> ConfigSection { get; set; }
        /// <summary>
        /// Gets or sets the settings details.
        /// </summary>
        /// <value>The settings details.</value>
        public List<ConfigListDataShotgunData> SettingsDetails { get; set; }
        /// <summary>
        /// Gets or sets the powder details.
        /// </summary>
        /// <value>The powder details.</value>
        public List<ConfigListPowderData> PowderDetails { get; set; }
    }
}
