using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using SportsMonk.SportMonkClient.Models.League;
using SportsMonk.SportMonkClient.Models.Standings;

namespace SportsMonk.SportMonkClient
{
    public class SportsMonkClient : ClientBase, ISportsMonkClient
    {
        public SportsMonkClient(string apiToken) : base(apiToken)
        {
        }

        public async Task<IList<LeagueResult>> AllLeagues(AllLeagueOptions allleagueOptions = null)
        {
            var url = BaseUrl
                .AppendPathSegment("leagues")
                .SetQueryParam("api_token", _apiToken);

            if (allleagueOptions != null)
            {
                url.SetQueryParam("include", string.Join(',', allleagueOptions.Options));
            }

            var response = await url.GetJsonAsync<AllLeaguesResponse>();
            return response.Data;
        }

        public async Task<IList<StandingResult>> Standing(int seasonId)
        {
            var url = BaseUrl
                .AppendPathSegment("standings")
                .AppendPathSegment("season")
                .AppendPathSegment(seasonId)
                .SetQueryParam("api_token", _apiToken);

            var response = await url.GetJsonAsync<StandingResponse>();
            return response.Data;
        }
    }
}