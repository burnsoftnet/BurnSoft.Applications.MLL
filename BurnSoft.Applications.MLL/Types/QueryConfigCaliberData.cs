

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class QueryConfigCaliberData list container to work with the qry_ConfigCal_NSG or qry_ConfigCal_SG Query.
    /// </summary>
    public class QueryConfigCaliberData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name for the ConfigName column
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is personal.
        /// </summary>
        /// <value><c>true</c> if this instance is personal; otherwise, <c>false</c>.</value>
        public bool IsPersonal { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is shot gun.
        /// </summary>
        /// <value><c>true</c> if this instance is shot gun; otherwise, <c>false</c>.</value>
        public bool IsShotGun { get; set; }
        /// <summary>
        /// Gets or sets the caliber identifier.
        /// </summary>
        /// <value>The caliber identifier.</value>
        public long CaliberId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        public bool IsActive { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is favorite for the IsFav column
        /// </summary>
        /// <value><c>true</c> if this instance is favoriate; otherwise, <c>false</c>.</value>
        public bool IsFavorite { get; set; }
    }
}
