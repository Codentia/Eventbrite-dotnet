using System;
using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class Event
  {
    [JsonProperty(PropertyName = "resource_uri")]
    public string ResourceUri { get; set; }

    [JsonProperty(PropertyName = "name")]
    public HybridString Name { get; set; }

    [JsonProperty(PropertyName = "description")]
    public HybridString Description { get; set; }

    [JsonProperty(PropertyName = "organizer")]
    public Organizer Organizer { get; set; }

    [JsonProperty(PropertyName = "venue")]
    public Venue Venue { get; set; }

    [JsonProperty(PropertyName = "ticket_classes")]
    public TicketClasses[] TicketClasses { get; set; }

    [JsonProperty(PropertyName = "id")]
    public long Id { get; set; }

    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    [JsonProperty(PropertyName = "start")]
    public HybridDate Start { get; set; }

    [JsonProperty(PropertyName = "end")]
    public HybridDate End { get; set; }

    [JsonProperty(PropertyName = "created")]
    public DateTime Created { get; set; }

    [JsonProperty(PropertyName = "changed")]
    public DateTime Changed { get; set; }

    [JsonProperty(PropertyName = "timezone")]
    public string Timezone { get; set; }

    [JsonProperty(PropertyName = "capacity")]
    public int Capacity { get; set; }

    [JsonProperty(PropertyName = "categories")]
    public object[] Categories { get; set; }

    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }
  }
}