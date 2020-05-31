using Microsoft.Extensions.Configuration;

namespace SportsMonk.SportsMonkClient.Tests.Integration
{
    public static class TestHelper
    {
        private static IConfigurationRoot GetIConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true)
                .AddUserSecrets<SportsMonkClientTests>()
                .AddEnvironmentVariables()
                .Build();
        }

        public static SportsMonkConfiguration GetSportsMonkConfiguration()
        {
            var configuration = new SportsMonkConfiguration();

            var iConfig = GetIConfigurationRoot();

            iConfig
                .GetSection("SportsMonk")
                .Bind(configuration);

            return configuration;
        }
    }
}