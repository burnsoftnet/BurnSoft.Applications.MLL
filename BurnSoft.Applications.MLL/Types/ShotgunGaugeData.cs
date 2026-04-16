

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ShotgunGaugeData is the list container for the List_SG_Gauge Table
    /// </summary>
    public class ShotgunGaugeData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name which is the gc column
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
