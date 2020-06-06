using System.Collections.Generic;
using System.Threading.Tasks;
using SportsMonk.SportMonkClient.Models;

namespace SportsMonk.SportMonkClient
{
    public interface ISportsMonkClient
    {
        Task<IList<League>> AllLeagues();
    }
}
