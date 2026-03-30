
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class WadData is the list container for the List_SG_WAD table
    /// </summary>
    public class WadData
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
        /// Gets or sets the name for the WAD Column
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the gauge.
        /// </summary>
        /// <value>The gauge.</value>
        public string Gauge { get; set; }
        /// <summary>
        /// Gets or sets the gauge identifier for the GID Column
        /// </summary>
        /// <value>The gauge identifier.</value>
        public long GaugeId { get; set; }
        /// <summary>
        /// Gets or sets Load in oz. text
        /// </summary>
        /// <value>The length.</value>
        public string LoadInOzText { get; set; }
        /// <summary>
        /// Gets or sets Load in oz. in numeric form, background calculation
        /// </summary>
        /// <value>The load in oz.</value>
        public double LoadInOz { get; set; }
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
        /// Gets or sets the Esitmated Price Per Shell. for the epps column
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
