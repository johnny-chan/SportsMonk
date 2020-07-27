using System.Collections.Generic;
using System.Threading.Tasks;
using SportsMonk.SportMonkClient.Models.League;

namespace SportsMonk.SportMonkClient
{
    public interface ISportsMonkClient
    {
        Task<IList<League>> AllLeagues(AllLeagueOptions allleagueOptions);
    }
}
