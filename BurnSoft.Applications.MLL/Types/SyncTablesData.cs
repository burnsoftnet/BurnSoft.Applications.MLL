

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class SyncTablesData list container for the sync_tables table.
    /// </summary>
    public class SyncTablesData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the table. for the tblname column
        /// </summary>
        /// <value>The name of the table.</value>
        public string TableName { get; set; }
    }
}
