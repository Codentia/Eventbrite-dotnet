using System;
using Newtonsoft.Json;

namespace Eventbrite.Entities
{
  public class TicketClasses
  {
    [JsonProperty(PropertyName = "id")]
    public long Id { get; set; }

    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [JsonProperty(PropertyName = "cost")]
    public object Cost { get; set; }

    [JsonProperty(PropertyName = "fee")]
    public object Fee { get; set; }

    [JsonProperty(PropertyName = "currency")]
    public object Currency { get; set; }

    [JsonProperty(PropertyName = "free")]
    public bool Free { get; set; }

    [JsonProperty(PropertyName = "minimum_quantity")]
    public int MinimumQuantity { get; set; }

    [JsonProperty(PropertyName = "maximum_quantity")]
    public object MaximumQuantity { get; set; }

    [JsonProperty(PropertyName = "quantity_total")]
    public int QuantityTotal { get; set; }

    [JsonProperty(PropertyName = "quantity_sold")]
    public int QuantitySold { get; set; }

    [JsonProperty(PropertyName = "sales_start")]
    public object SalesStart { get; set; }

    [JsonProperty(PropertyName = "sales_end")]
    public DateTime SalesEnd { get; set; }
  }
}