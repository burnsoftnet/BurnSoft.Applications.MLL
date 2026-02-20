
namespace BurnSoft.Applications.MLL.Types
{
    //TODO: Determine if this is still a feature that you wish to have for the application

    /// <summary>
    /// Class BulletPictures list container for the List_Bullets_Picture Table.
    /// This was put in some time ago but never used in the application.  Might
    /// Come back to this and add it, still Need to Create the functions to 
    /// interact with the table and data.
    /// </summary>
    public class BulletPictures
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the bullet identifier. Column name is BID
        /// </summary>
        /// <value>The bullet identifier.</value>
        public int BulletId { get; set; }
        /// <summary>
        /// Gets or sets the picute BLOB. Column Name is Pic_Blob
        /// </summary>
        /// <value>The picute BLOB.</value>
        public object PicuteBlob { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value><c>true</c> if this instance is default; otherwise, <c>false</c>.</value>
        public bool IsDefault { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
