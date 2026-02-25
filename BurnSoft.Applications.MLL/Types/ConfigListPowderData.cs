
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ConfigListPowderData is the list container for the 
    /// Config_List_Powder_Data_NSG ( Metalic ) and 
    /// Config_Lst_Powder_Data_SG ( Shotgun )
    /// </summary>
    public class ConfigListPowderData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id {  get; set; }
        /// <summary>
        /// Gets or sets the configuration identifier. for the CLNID column
        /// </summary>
        /// <value>The configuration identifier.</value>
        public long ConfigId { get; set; }
        /// <summary>
        /// Gets or sets the powder identifier. for the PID column
        /// </summary>
        /// <value>The powder identifier.</value>
        public long PowderId { get; set; }
        /// <summary>
        /// Gets or sets the load minimum. For the Load_Min Column
        /// Charge Weight in Grains
        /// </summary>
        /// <value>The load minimum.</value>
        public double LoadMin { get; set; }
        /// <summary>
        /// Gets or sets the load mid. For the Load_Mid column
        /// Charge Weight in Grains
        /// </summary>
        /// <value>The load mid.</value>
        public double LoadMid { get; set; }
        /// <summary>
        /// Gets or sets the load maximum. For the Load_Max column
        /// Charge Weight in Grains
        /// </summary>
        /// <value>The load maximum.</value>
        public double LoadMax { get; set; }
        /// <summary>
        /// Gets or sets the FPS minimum. for the FPS_Min Column
        /// Muzzle Velocity
        /// </summary>
        /// <value>The FPS minimum.</value>
        public double? FpsMin { get; set; }
        /// <summary>
        /// Gets or sets the FPS mid. for the FPS_Mid column
        /// Muzzle Velocity
        /// </summary>
        /// <value>The FPS mid.</value>
        public double? FpsMid { get; set; }
        /// <summary>
        /// Gets or sets the FPS maximum. for the FPS_Max column
        /// Muzzle Velocity
        /// </summary>
        /// <value>The FPS maximum.</value>
        public double? FpsMax { get; set; }
        /// <summary>
        /// Gets or sets the cups minimum. for the CUPS_Min column ( METALIC ONLY RELATED )
        /// Pressure C.U.P.S
        /// </summary>
        /// <value>The cups minimum.</value>
        public double? CupsMin { get; set; }
        /// <summary>
        /// Gets or sets the cups mid. for the CUPS_Mid column ( METALIC ONLY RELATED )
        /// Pressure C.U.P.S
        /// </summary>
        /// <value>The cups mid.</value>
        public double? CupsMid { get; set; }
        /// <summary>
        /// Gets or sets the cups maximum. For the CUPS_Max column ( METALIC ONLY RELATED )
        /// Pressure C.U.P.S
        /// </summary>
        /// <value>The cups maximum.</value>
        public double? CupsMax { get; set; }
        /// <summary>
        /// Gets or sets the psi minimum. for the PSI_Min column ( SHOTGUN RELATED )
        /// </summary>
        /// <value>The psi minimum.</value>
        public double? PsiMin { get; set; }
        /// <summary>
        /// Gets or sets the psi mid. for the PSI_Mid column ( SHOTGUN RELATED )
        /// </summary>
        /// <value>The psi mid.</value>
        public double? PsiMid { get; set; }
        /// <summary>
        /// Gets or sets the psi maximum. for the PSI_Max column ( SHOTGUN RELATED )
        /// </summary>
        /// <value>The psi maximum.</value>
        public double? PsiMax { get; set; }
        /// <summary>
        /// Gets or sets the lup minimum. for the LUP_Min column ( SHOTGUN RELATED )
        /// </summary>
        /// <value>The lup minimum.</value>
        public double? LupMin { get; set; }
        /// <summary>
        /// Gets or sets the lup mid. for the LUP_Mid column ( SHOTGUN RELATED )
        /// </summary>
        /// <value>The lup mid.</value>
        public double? LupMid { get; set; }
        /// <summary>
        /// Gets or sets the lup maximum. for the LUP_Max column ( SHOTGUN RELATED )
        /// </summary>
        /// <value>The lup maximum.</value>
        public double? LupMax { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is default. for the IsPref column
        /// </summary>
        /// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
        public bool IsDefault { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
