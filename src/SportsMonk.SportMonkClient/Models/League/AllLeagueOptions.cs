using System.Collections.Generic;
using SportsMonk.SportMonkClient.Models.League.Enums;

namespace SportsMonk.SportMonkClient.Models.League
{
    public class AllLeagueOptions   
    {
        public IEnumerable<AllLeagueEnums> Options { get; set; }
    }
}