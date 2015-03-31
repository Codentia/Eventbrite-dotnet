using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class Address
  {
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    [JsonProperty(PropertyName = "region")]
    public string Region { get; set; }

    [JsonProperty(PropertyName = "address_1")]
    public string Address1 { get; set; }

    [JsonProperty(PropertyName = "address_2")]
    public string Address2 { get; set; }

    [JsonProperty(PropertyName = "country_name")]
    public string CountryName { get; set; }
  }
}