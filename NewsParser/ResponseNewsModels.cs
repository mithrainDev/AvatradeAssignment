using System.Text.Json.Serialization;

namespace NewsParser;

public class ResponseNewsModels
{
    [JsonPropertyName("results")]
    public List<TradingNews> TradingNewsList { get; set; }
}

public class TradingNews
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("author")]
    public string? Author { get; set; }

    [JsonPropertyName("published_utc")]
    public DateTime PublishedUtc { get; set; }

    [JsonPropertyName("article_url")]
    public string? ArticleUrl { get; set; }

    [JsonPropertyName("tickers")]
    public List<string>? Tickers { get; set; }

    [JsonPropertyName("image_url")]
    public string? ImageUrl { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }
}