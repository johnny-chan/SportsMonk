using Newtonsoft.Json;
using SportsMonk.SportMonkClient.Models;
using SportsMonk.SportMonkClient.Models.League;

namespace SportsMonk.SportMonkClient.Serialization
{
    public static class Serializer
    {
        public static string ToJson(this AllLeaguesResponse self) => JsonConvert.SerializeObject(self, DefaultSerializationSettings.Settings);
    }
}