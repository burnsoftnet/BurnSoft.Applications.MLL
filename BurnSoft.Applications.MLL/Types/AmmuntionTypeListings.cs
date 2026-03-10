
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class AmmuntionTypeListings list container for the General_Ammunition_Type table
    /// </summary>
    public class AmmuntionTypeListings
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public long Id { get; set; }
        /// <summary>
        /// Gets or sets the type of the firearm for the FType column, 
        /// only really 3 choices, Pistol, Rifle, and Shotgun
        /// </summary>
        /// <value>The type of the firearm.</value>
        public string FirearmType { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }
    }
}
