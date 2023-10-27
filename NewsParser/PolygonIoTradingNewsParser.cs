using System.Text.Json;
using PolygonIoTradingNewsParser;

namespace NewsParser;

public class PolygonIoTradingNewsParser
{
    private readonly HttpClient _httpClient;
    private readonly ApiKeyConfiguration _apiKeyConfiguration;

    public PolygonIoTradingNewsParser(HttpClient httpClient, ApiKeyConfiguration apiKeyConfiguration)
    {
        _httpClient = httpClient;
        _apiKeyConfiguration = apiKeyConfiguration;
    }

    public async Task<ResponseNewsModels?> GetTradingNewsAsync(string ticker)
    {
        var requestUri =
            new Uri($"https://api.polygon.io/v2/reference/news?ticker={ticker}&apiKey={_apiKeyConfiguration.Key}");

        var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
        request.Headers.Add("Authorization", "Bearer WVAfX4fDjFAeeMdRf77YnCBdjMpowk0e");

        var response = await _httpClient.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var jsonResponse = await response.Content.ReadAsStringAsync();
            var tradingNewsList = JsonSerializer.Deserialize<ResponseNewsModels>(jsonResponse);
            return tradingNewsList;
        }
        else
        {
            throw new Exception($"Failed to get trading news for ticker {ticker}: {response.StatusCode}");
        }
    }
}