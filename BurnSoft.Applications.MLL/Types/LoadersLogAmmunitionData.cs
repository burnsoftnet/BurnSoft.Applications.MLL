


namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class LoadersLogAmmunitionData is the list container 
    /// for the Loader_Log_Ammunition Table
    /// </summary>
    public class LoadersLogAmmunitionData
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
        /// Gets or sets the caliber. Fpr the Cal Column
        /// </summary>
        /// <value>The caliber.</value>
        public string Caliber { get; set; }
        /// <summary>
        /// Gets or sets the grain.
        /// </summary>
        /// <value>The grain.</value>
        public string Grain { get; set; }
        /// <summary>
        /// Gets or sets the jacket.
        /// </summary>
        /// <value>The jacket.</value>
        public string Jacket { get; set; }
        /// <summary>
        /// Gets or sets the qty.
        /// </summary>
        /// <value>The qty.</value>
        public long Qty { get; set; }
        /// <summary>
        /// Gets or sets the grain double. For the dcal column
        /// </summary>
        /// <value>The grain double.</value>
        public double GrainDouble { get; set; }
        /// <summary>
        /// Gets or sets the velocity. for the Vel column
        /// </summary>
        /// <value>The velocity.</value>
        public int Velocity { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
