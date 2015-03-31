using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class Venue
  {
    [JsonProperty(PropertyName = "id")]
    public long Id { get; set; }

    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    [JsonProperty(PropertyName = "latitude")]
    public string Latitude { get; set; }

    [JsonProperty(PropertyName = "longitude")]
    public string Longitude { get; set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
  }
}