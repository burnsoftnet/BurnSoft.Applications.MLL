

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ConfigListDataMetalic list type for the Metalic/Non-Shotgun 
    /// ( Pistol/Rifle ) Data from the Config_List_Data_NSG table
    /// </summary>
    public class ConfigListDataMetalicData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the clnid.  Config List Name ID
        /// </summary>
        /// <value>The clnid.</value>
        public int ConfgId { get; set; }
        /// <summary>
        /// Gets or sets the atid. Ammunition Type ID
        /// </summary>
        /// <value>The atid.</value>
        public int AmmoTypeId { get; set; }
        /// <summary>
        /// Gets or sets the calid. Caliber ID
        /// </summary>
        /// <value>The calid.</value>
        public int CaliberId { get; set; }
        /// <summary>
        /// Gets or sets the bid. Bullet ID
        /// </summary>
        /// <value>The bid.</value>
        public int BulletId { get; set; }
        /// <summary>
        /// Gets or sets the prid. Primer ID
        /// </summary>
        /// <value>The prid.</value>
        public int PrimerId { get; set; }
        /// <summary>
        /// Gets or sets the caid. Case ID
        /// </summary>
        /// <value>The caid.</value>
        public int CaseId { get; set; }
        /// <summary>
        /// Gets or sets the source. If not Personal Referance a souce (optional)
        /// </summary>
        /// <value>The source.</value>
        public string Source { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
