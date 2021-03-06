using System.Xml.Serialization;

namespace Terminals.Data
{
    /// <summary>
    /// Base user authentication values. These are used when ever stored password is required.
    /// </summary>
    public interface ICredentialBase
    {
        /// <summary>
        /// Gets or sets the encrypted password. Depends on the master password key.
        /// </summary>
        string EncryptedPassword { get; set; }

        string EncryptedUserName { get; set; }

        string EncryptedDomain { get; set; }
    }
}