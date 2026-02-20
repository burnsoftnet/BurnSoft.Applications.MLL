

namespace BurnSoft.Applications.MLL.Types
{
    //TODO: Determine if this is still a feature that you wish to have for the application

    /// <summary>
    /// Class BulletSupportingCaliber list container for the List_Bullers_SupprtingCaliber 
    /// Table.  This related to the Bullet SIngle Use.
    /// This table was created to help with bullets that applied to more than one
    /// caliber.  Something like .355 9mm 115 can apply to .380.  Some other diameter 
    /// bullets can apply to other calibers
    /// </summary>
    public class BulletSupportingCaliber
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the bullet identifier. for Column BID
        /// </summary>
        /// <value>The bullet identifier.</value>
        public int BulletId { get; set; }
        /// <summary>
        /// Gets or sets the caliber identifier. For Column CID
        /// </summary>
        /// <value>The caliber identifier.</value>
        public int CaliberId { get; set; }
        /// <summary>
        /// Gets or sets the qty.
        /// </summary>
        /// <value>The qty.</value>
        public int Qty { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        public double Price { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
