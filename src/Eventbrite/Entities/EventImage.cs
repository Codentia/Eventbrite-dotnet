using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Eventbrite.Entities
{
    /// <summary>
    /// Image implementation
    /// </summary>
    public class EventImage
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the aspect ratio.
        /// </summary>
        /// <value>
        /// The aspect ratio.
        /// </value>
        [JsonProperty(PropertyName = "aspect_ratio")]
        public int AspectRatio { get; set; }

        /// <summary>
        /// Gets or sets the color of the edge.
        /// </summary>
        /// <value>
        /// The color of the edge.
        /// </value>
        [JsonProperty(PropertyName = "edge_color")]
        public string EdgeColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [edge color set].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [edge color set]; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty(PropertyName = "edge_color_set")]
        public bool EdgeColorSet { get; set; }
    }
}

