using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.ClientProtocol;
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
    }
}
