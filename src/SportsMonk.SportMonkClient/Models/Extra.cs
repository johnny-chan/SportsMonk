using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class Extra
    {
        [JsonProperty("continent")]
        public string Continent { get; set; }

        [JsonProperty("sub_region")]
        public string SubRegion { get; set; }

        [JsonProperty("world_region")]
        public string WorldRegion { get; set; }

        [JsonProperty("fifa")]
        public string Fifa { get; set; }

        [JsonProperty("iso")]
        public string Iso { get; set; }

        [JsonProperty("iso2")]
        public string Iso2 { get; set; }

        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [JsonProperty("latitude")]
        public string Latitude { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

    }
}
