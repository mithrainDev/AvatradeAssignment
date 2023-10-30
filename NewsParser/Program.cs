using Microsoft.Extensions.Configuration;
using PolygonIoTradingNewsParser;

namespace NewsParser
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var apiKeyConfiguration = new ApiKeyConfiguration();

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            apiKeyConfiguration.ApiKey = configuration.GetSection("ApiKey").Value;

            var polygonIoTradingNewsParser = new PolygonIoTradingNewsParser(httpClient, apiKeyConfiguration);

            var tradingNews = await polygonIoTradingNewsParser.GetTradingNewsAsync("USD");

            Console.WriteLine($"{tradingNews}");
        }
    }
}