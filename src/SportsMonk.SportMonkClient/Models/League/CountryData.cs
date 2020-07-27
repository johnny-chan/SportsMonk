using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class CountryData
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image_path")]
        public string ImagePath { get; set; }

        [JsonProperty("extra")]
        public Extra Extra { get; set; }
    }
}