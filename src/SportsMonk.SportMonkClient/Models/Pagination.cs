using Newtonsoft.Json;

namespace SportsMonk.SportMonkClient.Models
{
    public class Pagination
    {
        [JsonProperty("total")] public long Total { get; set; }

        [JsonProperty("count")] public long Count { get; set; }

        [JsonProperty("per_page")] public long PerPage { get; set; }

        [JsonProperty("current_page")] public long CurrentPage { get; set; }

        [JsonProperty("total_pages")] public long TotalPages { get; set; }

        [JsonProperty("links")] public Links Links { get; set; }
    }
}