

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class FirearmCollection list container for the local collection
    /// </summary>
    public class FirearmCollection
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets my gun collection identifier. Actual field is MGCID
        /// </summary>
        /// <value>My gun collection identifier.</value>
        public int MyGunCollectionId { get; set; }
        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>The full name.</value>
        public string FullName { get; set; }
        /// <summary>
        /// Gets or sets the manufacturer.  Actual Field is Manu
        /// </summary>
        /// <value>The manufacturer.</value>
        public string Manufacturer {  get; set; }
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model.</value>
        public string Model { get; set; }
        /// <summary>
        /// Gets or sets the caliber.  Actual field is Cal
        /// </summary>
        /// <value>The caliber.</value>
        public string Caliber { get; set; }
        /// <summary>
        /// Gets or sets the barrel.
        /// </summary>
        /// <value>The barrel.</value>
        public string Barrel { get; set; }
        /// <summary>
        /// Gets or sets the serial no.
        /// </summary>
        /// <value>The serial no.</value>
        public string SerialNo { get; set; }
        /// <summary>
        /// Gets or sets the type of the gun. Actual Field is GType
        /// </summary>
        /// <value>The type of the gun.</value>
        public string GunType { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FirearmCollection"/> is exclude.
        /// </summary>
        /// <value><c>true</c> if exclude; otherwise, <c>false</c>.</value>
        public bool Exclude { get; set; }

        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }

    }
}
