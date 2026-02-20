
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class CaseListings list container for the List_Case table
    /// </summary>
    public class CaseListings
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
        /// Gets or sets the length of the trim to.
        /// </summary>
        /// <value>The length of the trim to.</value>
        public string TrimToLength { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is new.
        /// </summary>
        /// <value><c>true</c> if this instance is new; otherwise, <c>false</c>.</value>
        public bool IsNew { get; set; }
        /// <summary>
        /// Gets or sets the times used.
        /// </summary>
        /// <value>The times used.</value>
        public int TimesUsed { get; set; }
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
        public long CaliberId { get; set; }
        /// <summary>
        /// Gets or sets the estimated price per case. Using the ePPC column
        /// </summary>
        /// <value>The estimated price per case.</value>
        public double EstimatedPricePerCase { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
