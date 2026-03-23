

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ShotgunHullData list container for the List_SG_Case table.
    /// </summary>
    public class ShotgunHullData
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
        /// Gets or sets the gauge.
        /// </summary>
        /// <value>The gauge.</value>
        public string Gauge { get; set; }
        /// <summary>
        /// Gets or sets the gun identifier. for the GID column
        /// </summary>
        /// <value>The gun identifier.</value>
        public long GunId { get; set; }
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>The length.</value>
        public string Length { get; set; }
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
        /// Gets or sets the dram.
        /// </summary>
        /// <value>The dram.</value>
        public string DRAM { get; set; }
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
