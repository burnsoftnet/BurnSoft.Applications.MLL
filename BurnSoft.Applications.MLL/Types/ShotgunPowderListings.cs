
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class ShotgunPowderListings list container for the List_SG_Bushing_Powder table.
    /// </summary>
    public class ShotgunPowderListings
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
        /// Gets or sets the name. for the sName column
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the charge for the sCharge Column
        /// </summary>
        /// <value>The charge.</value>
        public string Charge { get; set; }
        /// <summary>
        /// Gets or sets the type. for the sType Column
        /// </summary>
        /// <value>The type.</value>
        public string Type { get; set; }
        /// <summary>
        /// Gets or sets the name of the powder.
        /// </summary>
        /// <value>The name of the powder.</value>
        public string PowderName { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
