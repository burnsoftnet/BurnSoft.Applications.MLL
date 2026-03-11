
using System;

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class LoadersLogShotgunData list container for the Loaders_Log_SG table.
    /// </summary>
    public class LoadersLogShotgunData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the firearm identifier. for the fid column
        /// </summary>
        /// <value>The firearm identifier.</value>
        public long FirearmId { get; set; }
        /// <summary>
        /// Gets or sets the name of the configuration.
        /// </summary>
        /// <value>The name of the configuration.</value>
        public string ConfigName { get; set; }
        /// <summary>
        /// Gets or sets the caliber.
        /// </summary>
        /// <value>The caliber.</value>
        public string Caliber { get; set; }
        /// <summary>
        /// Gets or sets the name of the firearm.
        /// </summary>
        /// <value>The name of the firearm.</value>
        public string FirearmName { get; set; }
        /// <summary>
        /// Gets or sets the length of the barrel. for the BarrelLen column
        /// </summary>
        /// <value>The length of the barrel.</value>
        public string BarrelLength { get; set; }
        /// <summary>
        /// Gets or sets the date created. for the dt column
        /// </summary>
        /// <value>The date created.</value>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Gets or sets the yards. for the yds column
        /// </summary>
        /// <value>The yards.</value>
        public int Yards { get; set; }

        public string GroupSize { get; set; }

        public int NumberOfShots { get; set; }
        /// <summary>
        /// Gets or sets the powder details, powder - wt. - mfg for the pwn column
        /// </summary>
        /// <value>The powder details.</value>
        public string PowderDetails { get; set; }

        public string BulletDetails { get; set; }
        /// <summary>
        /// Gets or sets the primer details. for the primer column
        /// </summary>
        /// <value>The primer details.</value>
        public string PrimerDetails { get; set; }

        public string CaseDetails { get; set; }

        public string TotalLenght { get; set; }

        public string Conditions { get; set; }
        
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
