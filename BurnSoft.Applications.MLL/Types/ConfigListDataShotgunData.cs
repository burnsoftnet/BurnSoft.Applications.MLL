
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ConfigListDataShotgunData is the list container 
    /// for the Config_List_Data_SG table
    /// </summary>
    public class ConfigListDataShotgunData
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
        public int ConfgNameId { get; set; }
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
        /// Gets or sets the prid. Primer ID
        /// Primer ID from General_Primer
        /// </summary>
        /// <value>The prid.</value>
        public int PrimerId { get; set; }
        /// <summary>
        /// Gets or sets the caid. Case ID
        /// Case ID from List_SG_Case
        /// </summary>
        /// <value>The caid.</value>
        public int CaseId { get; set; }
        /// <summary>
        /// Gets or sets the shot weight. for the SW column
        /// Shot Weight from List_SG_ShotWeight
        /// </summary>
        /// <value>The shot weight.</value>
        public double ShotWeight { get; set; }
        /// <summary>
        /// Gets or sets the shot weight text. for the SW_t column
        /// Shot Weight in Text
        /// </summary>
        /// <value>The shot weight text.</value>
        public string ShotWeightText { get; set; }
        /// <summary>
        /// Gets or sets the size of the shot. for the SS column
        /// Shot Size from List_SG_ShotSize
        /// </summary>
        /// <value>The size of the shot.</value>
        public long ShotSize { get; set; }
        /// <summary>
        /// Gets or sets the bushing.
        /// Bushing from List_SG_Bushing
        /// </summary>
        /// <value>The bushing.</value>
        public long Bushing {  get; set; }
        /// <summary>
        /// Gets or sets the wad.
        /// WAD from List_SG_WAD
        /// </summary>
        /// <value>The wad.</value>
        public long Wad {  get; set; }
        /// <summary>
        /// Gets or sets the shot charge load. for the SCL Column,
        /// ShotCharge Loads from List_SG_ShotCharge_Loads
        /// </summary>
        /// <value>The shot charge load.</value>
        public long ShotChargeLoad { get; set; }
        /// <summary>
        /// Gets or sets the source. If not Personal Referance a souce (optional)
        /// </summary>
        /// <value>The source.</value>
        public string Source { get; set; }
        /// <summary>
        /// Gets or sets the gun identifier. for the GID column
        /// </summary>
        /// <value>The gun identifier.</value>
        public long GunId {  get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is personal.
        /// </summary>
        /// <value><c>true</c> if this instance is personal; otherwise, <c>false</c>.</value>
        public bool IsPersonal { get; set; }
        /// <summary>
        /// Gets or sets the list type identifier. for the LTID column
        /// List Type ID
        /// </summary>
        /// <value>The list type identifier.</value>
        public long ListTypeId { get; set; }
        /// <summary>
        /// Gets or sets the bushing identifier.
        /// </summary>
        /// <value>The bushing identifier.</value>
        public long BushingId { get; set; }
        /// <summary>
        /// Gets or sets the charge bar identifier.
        /// </summary>
        /// <value>The charge bar identifier.</value>
        public long ChargeBarId { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
