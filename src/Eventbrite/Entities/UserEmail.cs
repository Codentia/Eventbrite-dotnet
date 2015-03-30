using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class UserEmail
  {
    /// <summary>
    /// The email address.
    /// </summary>
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }
    /// <summary>
    /// If this email address has been verified to belong to the user.
    /// </summary>
    [JsonProperty(PropertyName = "verified")]
    public bool Verified { get; set; }
    /// <summary>
    /// If this email address is the primary one for the account.
    /// </summary>
    [JsonProperty(PropertyName = "primary")]
    public bool Primary { get; set; }
    
  }
}