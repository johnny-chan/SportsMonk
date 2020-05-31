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
                //.AddUserSecrets("e3dfcccf-0cb3-423a-b302-e3e92e95c128")
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