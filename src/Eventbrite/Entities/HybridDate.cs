using System;
using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class HybridDate
  {
    [JsonProperty(PropertyName = "timezone")]
    public string Timezone { get; set; }

    [JsonProperty(PropertyName = "local")]
    public DateTime Local { get; set; }

    [JsonProperty(PropertyName = "utc")]
    public DateTime Utc { get; set; }
  }
}