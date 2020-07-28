using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using SportsMonk.SportMonkClient.Models.League;
using SportsMonk.SportMonkClient.Models.League.Enums;
using SportsMonk.SportMonkClient.Models.Standings;
using Xunit;

namespace SportsMonk.SportsMonkClient.Tests.Integration
{
    public class SportsMonkClientTests
    {
        private SportMonkClient.SportsMonkClient sut;

        public SportsMonkClientTests()
        {
            var configuration = TestHelper.GetSportsMonkConfiguration();
            sut = new SportMonkClient.SportsMonkClient(configuration.ApiToken);
        }

        [Fact]
        public void Should_Return_All_Leagues()
        {
            var leagues = sut.AllLeagues().Result;
            leagues.Should().HaveCountGreaterThan(0);
        }

        [Fact]
        public void Should_Return_All_Leagues_With_Includes()
        {
            var allLeagueOptions = new AllLeagueOptions
            {
                Options = new List<AllLeagueEnums>
                {
                    AllLeagueEnums.Country,
                    AllLeagueEnums.Season
                }
            };

            var leagues = sut.AllLeagues(allLeagueOptions).Result;
            leagues.Should().HaveCountGreaterThan(0);
        }

        [Fact]
        public void Should_Return_Standings_For_A_Season()
        {
            var result = sut.Standing(16222).Result;
            result.Should().HaveCountGreaterOrEqualTo(0);
            result.First().Standings.Data.First().TeamName.Should().Be("Celtic");
        }

    }
}
