using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureDevOpsDarkySky.Models
{
    public class CurrentlyModel
    {
        [JsonProperty(PropertyName = "time")]
        public long Time
        { get; set; }

        [JsonProperty(PropertyName = "summary")]
        public string Summary
        { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon
        { get; set; }

        [JsonProperty(PropertyName = "precipIntensity")]
        public double PrecipIntensity
        { get; set; }

        [JsonProperty(PropertyName = "precipProbability")]
        public double PrecipProbability
        { get; set; }

        [JsonProperty(PropertyName = "temperature")]
        public double Temperature
        { get; set; }

        [JsonProperty(PropertyName = "apparentTemperature")]
        public double ApparentTemperature
        { get; set; }

        [JsonProperty(PropertyName = "dewPoint")]
        public double DewPoint
        { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public double Humidity
        { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public double Pressure
        { get; set; }

        [JsonProperty(PropertyName = "windSpeed")]
        public double WindSpeed
        { get; set; }

        [JsonProperty(PropertyName = "windGust")]
        public double WindGust
        { get; set; }

        [JsonProperty(PropertyName = "windBearing")]
        public double WindBearing
        { get; set; }

        [JsonProperty(PropertyName = "cloudCover")]
        public double CloudCover
        { get; set; }

        [JsonProperty(PropertyName = "uvIndex")]
        public double UvIndex
        { get; set; }

    }
}
