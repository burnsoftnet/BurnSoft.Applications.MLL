
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
        /// <summary>
        /// Gets or sets the shot weight. for the Shotwt column
        /// </summary>
        /// <value>The shot weight.</value>
        public string ShotWeight { get; set; }
        /// <summary>
        /// Gets or sets the size of the shot. for the ShotSize column
        /// </summary>
        /// <value>The size of the shot.</value>
        public string ShotSize { get; set; }
        /// <summary>
        /// Gets or sets the wad details. for the wad column
        /// </summary>
        /// <value>The wad details.</value>
        public string WadDetails { get; set; }
        /// <summary>
        /// Gets or sets the powder details, powder - wt. - mfg for the pbm column
        /// </summary>
        /// <value>The powder details.</value>
        public string PowderDetails { get; set; }
        /// <summary>
        /// Gets or sets the case details. for the case column
        /// </summary>
        /// <value>The case details.</value>
        public string CaseDetails { get; set; }
        /// <summary>
        /// Gets or sets the primer details. for the primer column
        /// </summary>
        /// <value>The primer details.</value>
        public string PrimerDetails { get; set; }
        /// <summary>
        /// Gets or sets the pattern density. for the pd column
        /// </summary>
        /// <value>The pattern density.</value>
        public string PatternDensity { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
