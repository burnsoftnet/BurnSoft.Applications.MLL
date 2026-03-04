
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class GunCollectionAmmo list container for the Gun_Collection_Ammo Table.
    /// This table is where the generated "Make Ammo" window stores all the loads 
    /// that was created and store that qty in this table.  Then you have the 
    /// option to move it to the Gun Collection Application Ammo Inventory Table.
    /// </summary>
    public class GunCollectionAmmoData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the manufacturer.
        /// </summary>
        /// <value>The manufacturer.</value>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the caliber.
        /// </summary>
        /// <value>The caliber.</value>
        public string Caliber { get; set; }
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        public string Weight { get; set; }
        /// <summary>
        /// Gets or sets the jacket.
        /// </summary>
        /// <value>The jacket.</value>
        public string Jacket { get; set; }
        /// <summary>
        /// Gets or sets the qty.
        /// </summary>
        /// <value>The qty.</value>
        public long Qty { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the weight double.
        /// </summary>
        /// <value>The weight double.</value>
        public double WeightDouble { get; set; }
        // <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
