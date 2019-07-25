namespace Amorous.Core.Models
{
    /// <summary>
    /// Base model of domain application user
    /// </summary>
    public abstract class ApplicationUser : DomainUser
    {

        /// <summary>
        /// Essential Identity of application user. <see cref="ApplicationUser"/>
        /// are authenticated across various applicationContext as having a token identifier.
        /// </summary>
        public string Token { get; set; }
    }
}
