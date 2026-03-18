
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class SearchFieldsData list container for the Search_Fields and Search_Fields_SG tables
    /// </summary>
    public class SearchFieldsData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the description. For the Dis Column
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the name of the column. for the colname column
        /// </summary>
        /// <value>The name of the column.</value>
        public string ColumnName { get; set; }
        /// <summary>
        /// Gets or sets the type of the column. for the cType column
        /// </summary>
        /// <value>The type of the column.</value>
        public string ColumnType { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
