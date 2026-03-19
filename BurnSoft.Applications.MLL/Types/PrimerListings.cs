

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class PrimerListings list container for the General_Primer table
    /// </summary>
    public class PrimerListings
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
        /// Gets or sets the primer type identifier.
        /// </summary>
        /// <value>The primer type identifier.</value>
        public int PrimerTypeId { get; set; }
        /// <summary>
        /// Gets or sets the type of the primer.
        /// </summary>
        /// <value>The type of the primer.</value>
        public string PrimerType { get; set; }
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
        /// Gets or sets the price per primer.
        /// </summary>
        /// <value>The price per primer.</value>
        public double PricePerPrimer { get; set; }
        // <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
