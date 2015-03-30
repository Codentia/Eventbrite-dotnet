using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class User
  {
    /// <summary>
    /// The user's id
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public int Id { get; set; }
    /// <summary>
    /// The user’s name. Use this in preference to first_name/last_name if possible for forward compatibility with non-Western names.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
    /// <summary>
    /// The user’s first name.
    /// </summary>
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }
    /// <summary>
    /// The user’s last name.
    /// </summary>
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }
    /// <summary>
    /// A list of user emails.
    /// </summary>
    [JsonProperty(PropertyName = "emails")]
    public IList<UserEmail> Emails { get; set; }
  }
}
