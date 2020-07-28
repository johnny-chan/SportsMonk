namespace SportsMonk.SportMonkClient
{
    public class ClientBase
    {
        protected readonly string _apiToken;

        protected ClientBase(string apiToken)
        {
            _apiToken = apiToken;
        }

        protected static string BaseUrl => "https://soccer.sportmonks.com/api/v2.0";
    }
}