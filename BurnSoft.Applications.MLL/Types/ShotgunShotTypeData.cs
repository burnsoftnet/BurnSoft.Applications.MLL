

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ShotgunShotTypeData is the list container for 
    /// the List_SG_ShotType_Details table
    /// </summary>
    public class ShotgunShotTypeData
    {
        // <summary>
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
        /// Gets or sets a value indicating whether this instance is slug.
        /// </summary>
        /// <value><c>true</c> if this instance is slug; otherwise, <c>false</c>.</value>
        public bool IsSlug { get; set; }
        /// <summary>
        /// Gets or sets the material used for the mat column
        /// </summary>
        /// <value>The material used.</value>
        public string MaterialUsed { get; set; }
        /// <summary>
        /// Gets or sets the shot number for the ShotNo volumn
        /// </summary>
        /// <value>The shot number.</value>
        public string ShotNumber { get; set; }
        /// <summary>
        /// Gets or sets the weight fort he weight column
        /// </summary>
        /// <value>The weight.</value>
        public string Weight { get; set; }
        /// <summary>
        /// Gets or sets the Caliber for the CAL column
        /// </summary>
        /// <value>The slug details.</value>
        public string Caliber { get; set; }
        /// <summary>
        /// Gets or sets the ounces.
        /// </summary>
        /// <value>The ounces.</value>
        public double Ounces { get; set; }
        /// <summary>
        /// Gets or sets the grams.
        /// </summary>
        /// <value>The grams.</value>
        public double Grams { get; set; }
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
        /// Gets or sets the estimated price per item in the epps column
        /// </summary>
        /// <value>The estimated price per item.</value>
        public double EstimatedPricePerItem { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
