using System.Text.Json.Serialization;

namespace DXKuma.Backend.Response.DivingFish;

public class DfB50
{
    [JsonPropertyName("additional_rating")]
    public int AdditionalRating { get; set; }

    [JsonPropertyName("charts")] public DfCharts? Charts { get; set; }

    [JsonPropertyName("nickname")] public string? Nickname { get; set; }

    [JsonPropertyName("plate")] public string? Plate { get; set; }

    [JsonPropertyName("rating")] public int Rating { get; set; }

    [JsonPropertyName("user_general_data")]
    public object? UserGeneralData { get; set; }

    [JsonPropertyName("username")] public string? Username { get; set; }
}