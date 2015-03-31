using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class HybridString
  {
    [JsonProperty(PropertyName = "text")]
    public string Text { get; set; }

    [JsonProperty(PropertyName = "html")]
    public string Html { get; set; }
  }
}