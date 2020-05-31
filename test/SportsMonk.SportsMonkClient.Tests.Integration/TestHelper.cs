using System;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace SportsMonk.SportsMonkClient.Tests.Integration
{
    public static class TestHelper
    {
        public static IConfigurationRoot GetIConfigurationRoot()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
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