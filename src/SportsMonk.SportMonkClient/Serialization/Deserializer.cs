using Newtonsoft.Json;
using SportsMonk.SportMonkClient.Models;
using SportsMonk.SportMonkClient.Models.League;

namespace SportsMonk.SportMonkClient.Serialization
{
    public class Deserializer
    {
        public static AllLeaguesResponse FromJson(string json) => JsonConvert.DeserializeObject<AllLeaguesResponse>(json, DefaultSerializationSettings.Settings);
    }
}