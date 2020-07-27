using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using SportsMonk.SportMonkClient.Models.League;

namespace SportsMonk.SportMonkClient
{
    public class SportsMonkClient : ISportsMonkClient
    {
        private readonly string _apiToken;

        public SportsMonkClient(string apiToken)
        {
            _apiToken = apiToken;
        }

        public async Task<IList<League>> AllLeagues(AllLeagueOptions allleagueOptions = null)
        {
            var url = "https://soccer.sportmonks.com/api/v2.0"
                .AppendPathSegment("leagues")
                .SetQueryParam("api_token", _apiToken);

            if (allleagueOptions != null)
            {
                url.SetQueryParam("include", string.Join(',', allleagueOptions.Options));
            }
                
            var response = await url.GetJsonAsync<AllLeaguesResponse>();
            return response.Data;
        }
    }
}
