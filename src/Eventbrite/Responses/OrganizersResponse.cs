using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventbrite.Entities;
using Newtonsoft.Json;

namespace Eventbrite.Responses
{
    public class OrganizersResponse
    {
        [JsonProperty(PropertyName = "pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty(PropertyName = "organizers")]
        public IList<Organizer> Organizers { get; set; }
    }
}
