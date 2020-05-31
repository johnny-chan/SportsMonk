using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SportsMonk.SportMonkClient.Serialization
{
    public static class DefaultSerializationSettings
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
