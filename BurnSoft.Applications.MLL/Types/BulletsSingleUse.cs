
namespace BurnSoft.Applications.MLL.Types
{
    //TODO: Determine if this is still a feature that you wish to have for the application

    /// <summary>
    /// Class BulletsSingleUse list container for the List_Bullets_SU table.
    /// This table was created to help with bullets that applied to more than one
    /// caliber.  Something like .355 9mm 115 can apply to .380.  Some other diameter 
    /// bullets can apply to other calibers
    /// </summary>
    public class BulletsSingleUse
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the suggested used identifier.  Column Name is SUID
        /// </summary>
        /// <value>The suggested used identifier.</value>
        public int SuggestedUsedId { get; set; }
        /// <summary>
        /// Gets or sets the bullet identifier. Column Name is BulletID
        /// </summary>
        /// <value>The bullet identifier.</value>
        public int BulletId { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
