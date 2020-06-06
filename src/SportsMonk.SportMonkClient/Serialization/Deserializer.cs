using Newtonsoft.Json;
using SportsMonk.SportMonkClient.Models;

namespace SportsMonk.SportMonkClient.Serialization
{
    public class Deserializer
    {
        public static AllLeaguesResponse FromJson(string json) => JsonConvert.DeserializeObject<AllLeaguesResponse>(json, DefaultSerializationSettings.Settings);
    }
}