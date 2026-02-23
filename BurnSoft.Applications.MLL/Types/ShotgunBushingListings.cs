

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ShotgunBushing is the list container for the List_SG_Bushing Table
    /// </summary>
    public class ShotgunBushingListings
    {
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
        /// Gets or sets the charge for the sCharge Column
        /// </summary>
        /// <value>The charge.</value>
        public string Charge { get; set; }
        /// <summary>
        /// Gets or sets for shot ID
        /// </summary>
        /// <value>For shot.</value>
        public long ForShot { get; set; }
        /// <summary>
        /// Gets or sets for powder Id
        /// </summary>
        /// <value>For powder.</value>
        public long ForPowder { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
