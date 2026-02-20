

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class CaliberLists list container for the List_Calibers Table
    /// </summary>
    public class CaliberLists
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the caliber. for the Cal Column
        /// </summary>
        /// <value>The caliber.</value>
        public string Caliber {  get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
