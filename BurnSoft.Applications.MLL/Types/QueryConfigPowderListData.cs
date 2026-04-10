
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class QueryConfigPowderListData list container for the qry_CFG_SR_PowderList
    /// </summary>
    public class QueryConfigPowderListData
    {
        /// <summary>
        /// Gets or sets the configuration identifier.
        /// </summary>
        /// <value>The configuration identifier.</value>
        public long ConfigId { get; set; }
        /// <summary>
        /// Gets or sets the name of the configuration.
        /// </summary>
        /// <value>The name of the configuration.</value>
        public string ConfigName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is personal.
        /// </summary>
        /// <value><c>true</c> if this instance is personal; otherwise, <c>false</c>.</value>
        public bool IsPersonal { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is shot gun.
        /// </summary>
        /// <value><c>true</c> if this instance is shot gun; otherwise, <c>false</c>.</value>
        public bool IsShotGun { get; set; }
        /// <summary>
        /// Gets or sets the name of the caliber.
        /// </summary>
        /// <value>The name of the caliber.</value>
        public string CaliberName { get; set; }
        /// <summary>
        /// Gets or sets the caliber identifier.
        /// </summary>
        /// <value>The caliber identifier.</value>
        public long CaliberId { get; set; }
        /// <summary>
        /// Gets or sets the powder manufacturer.
        /// </summary>
        /// <value>The powder manufacturer.</value>
        public string PowderManufacturer { get; set; }
        /// <summary>
        /// Gets or sets the name of the powder.
        /// </summary>
        /// <value>The name of the powder.</value>
        public string PowderName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is default charge load.
        /// </summary>
        /// <value><c>true</c> if this instance is default charge load; otherwise, <c>false</c>.</value>
        public bool IsDefaultChargeLoad { get; set; }
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
        /// Gets or sets the bullet manufacturer.
        /// </summary>
        /// <value>The bullet manufacturer.</value>
        public string BulletManufacturer { get; set; }
        /// <summary>
        /// Gets or sets the name of the bullet.
        /// </summary>
        /// <value>The name of the bullet.</value>
        public string BulletName { get; set; }
        /// <summary>
        /// Gets or sets the bullet diameter.
        /// </summary>
        /// <value>The bullet diameter.</value>
        public string BulletDiameter { get; set; }
        /// <summary>
        /// Gets or sets the bullet weight.
        /// </summary>
        /// <value>The bullet weight.</value>
        public string BulletWeight { get; set; }

    }
}
