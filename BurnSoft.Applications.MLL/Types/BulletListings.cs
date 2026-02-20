
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class BulletListings for the List_Bullets table
    /// </summary>
    public class BulletListings
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
        /// Gets or sets the diameter.
        /// </summary>
        /// <value>The diameter.</value>
        public string Diameter { get; set; }
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        public string Weight { get; set; }
        /// <summary>
        /// Gets or sets the section density. Using the Sec_Den column
        /// </summary>
        /// <value>The section density.</value>
        public string SectionDensity { get; set; }
        /// <summary>
        /// Gets or sets the part number.  Using the Part_number column
        /// </summary>
        /// <value>The part number.</value>
        public string PartNumber { get; set; }
        /// <summary>
        /// Gets or sets the ballistic coeffcient. Using the Ballistic_Coefficient column
        /// </summary>
        /// <value>The ballistic coeffcient.</value>
        public string BallisticCoeffcient { get; set; }
        /// <summary>
        /// Gets or sets the type of the buller. Using the Bullet_Type column
        /// </summary>
        /// <value>The type of the buller.</value>
        public int BullerType { get; set; }
        /// <summary>
        /// Gets or sets the qty.
        /// </summary>
        /// <value>The qty.</value>
        public int Qty { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the caliber identifier. Using the CID column
        /// </summary>
        /// <value>The caliber identifier.</value>
        public int CaliberId { get; set; }
        /// <summary>
        /// Gets or sets the esitmated price per bullet. Using the ePPB column
        /// </summary>
        /// <value>The esitmated price per bullet.</value>
        public double EsitmatedPricePerBullet { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
