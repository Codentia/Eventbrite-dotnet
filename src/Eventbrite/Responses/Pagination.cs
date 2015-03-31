using Newtonsoft.Json;

namespace Eventbrite.Responses
{
  public class Pagination
  {
    [JsonProperty(PropertyName = "object_count")]
    public int ObjectCount { get; set; }
    [JsonProperty(PropertyName = "page_number")]
    public int PageNumber { get; set; }
    [JsonProperty(PropertyName = "page_size")]
    public int PageSize { get; set; }
    [JsonProperty(PropertyName = "page_count")]
    public int PageCount { get; set; }
  }
}