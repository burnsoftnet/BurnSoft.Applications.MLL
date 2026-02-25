
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class EquipmentLists list container for the General_Equipment table
    /// </summary>
    public class EquipmentLists
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
        /// Gets or sets the diameter.
        /// </summary>
        /// <value>The diameter.</value>
        public string Use { get; set; }
        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public double Cost { get; set; }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>The notes.</value>
        public string Notes { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
