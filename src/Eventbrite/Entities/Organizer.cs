using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class Organizer
  {
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public long Id { get; set; }
    /// <summary>
    /// The organizer’s name.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }
    /// <summary>
    /// The URL to the organizer’s page on Eventbrite.
    /// </summary>
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "num_past_events")]
    public int NumberOfPastEvents { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "num_future_events")]
    public int NumberOfFutureEvents { get; set; }
  }
}