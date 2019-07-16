using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevOpsDarkySky.Models
{
    public class MainModel
    {
        [JsonProperty(PropertyName = "latitude")]
        public string Latitude
        { get; set; }

        [JsonProperty(PropertyName = "longitude")]
        public string Longitude
        { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public string Timezone
        { get; set; }

        [JsonProperty(PropertyName = "currently")]
        public CurrentlyModel Currently
        { get; set; }
    }
}
