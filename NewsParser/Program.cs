using PolygonIoTradingNewsParser;

namespace NewsParser
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var apiKeyConfiguration = new ApiKeyConfiguration();

            var polygonIoTradingNewsParser = new PolygonIoTradingNewsParser(httpClient, apiKeyConfiguration);

            var tradingNews = await polygonIoTradingNewsParser.GetTradingNewsAsync("USD");

            Console.WriteLine($"{tradingNews}");
        }
    }
}