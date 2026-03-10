

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class PowderListing list container for the General_Powder
    /// </summary>
    public class PowderListing
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
        /// Gets or sets the weight in pounds. for the weightlbs colum
        /// </summary>
        /// <value>The weight in pounds.</value>
        public double WeightInPounds { get; set; }
        /// <summary>
        /// Gets or sets the weight in grains. for the weightgn column
        /// </summary>
        /// <value>The weight in grains.</value>
        public double WeightInGrains { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price {  get; set; }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>The notes.</value>
        public string Notes { get; set; }
        /// <summary>
        /// Gets or sets the price per grain. for the ePPP column
        /// </summary>
        /// <value>The price per grain.</value>
        public double PricePerGrain { get; set; }
        // <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
