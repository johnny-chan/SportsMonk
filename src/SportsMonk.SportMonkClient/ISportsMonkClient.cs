using System.Collections.Generic;
using System.Threading.Tasks;
using SportsMonk.SportMonkClient.Models.League;
using SportsMonk.SportMonkClient.Models.Standings;

namespace SportsMonk.SportMonkClient
{
    public interface ISportsMonkClient
    {
        Task<IList<LeagueResult>> AllLeagues(AllLeagueOptions allleagueOptions);

        Task<IList<StandingResult>> Standing(int seasonId);
    }
}