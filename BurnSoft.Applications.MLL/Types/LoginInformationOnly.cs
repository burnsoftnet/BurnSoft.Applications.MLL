
namespace BurnSoft.Applications.MLL.Types
{
    /// <summary>
    /// Class LoginInformationOnly.  List container for login information only
    /// </summary>
    public class LoginInformationOnly
    {
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
    }
}
