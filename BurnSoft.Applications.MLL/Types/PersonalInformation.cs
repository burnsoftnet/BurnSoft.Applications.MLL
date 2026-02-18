using System;

namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class PersonalInformation Type for Personal_Information Table.
    /// </summary>
    public class PersonalInformation
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the load for the Load_Name column.
        /// </summary>
        /// <value>The name of the load.</value>
        public string LoadName { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public string State { get; set; }
        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>The zip code.</value>
        public string ZipCode { get; set; }
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>The phone number.</value>
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the license/lic column
        /// </summary>
        /// <value>The license.</value>
        public string License { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [use lock].
        /// </summary>
        /// <value><c>true</c> if [use lock]; otherwise, <c>false</c>.</value>
        public bool UseLock { get; set; }
        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>The name of the user.</value>
        public string UserName { get; set; }
        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string Password { get; set; }
        /// <summary>
        /// Gets or sets the forgot for the Password_Forgot column
        /// </summary>
        /// <value>The forgot.</value>
        public string Forgot { get; set; }
        /// <summary>
        /// Gets or sets the forget phrase for the Password_Forgot_word column
        /// </summary>
        /// <value>The forget phrase.</value>
        public string ForgetPhrase { get; set; }
        /// <summary>
        /// Gets or sets the last synchronize for the sync_lastupdate column
        /// </summary>
        /// <value>The last synchronize.</value>
        public string LastSync { get; set; }

    }
}
