using System.Text.Json.Serialization;

namespace DXKuma.Backend.Response.DivingFish;

public class DfScore
{
    [JsonPropertyName("achievements")] public float Achievements { get; set; }

    [JsonPropertyName("ds")] public float Ds { get; set; }

    [JsonPropertyName("dxScore")] public int DxScore { get; set; }

    [JsonPropertyName("fc")] public string? Combo { get; set; }

    [JsonPropertyName("fs")] public string? Sync { get; set; }

    [JsonPropertyName("level")] public string? Level { get; set; }

    [JsonPropertyName("level_index")] public LevelIndex LevelIndex { get; set; }

    [JsonPropertyName("level_label")] public string? LevelLabel { get; set; }

    [JsonPropertyName("ra")] public int Ra { get; set; }

    [JsonPropertyName("rate")] public string? Rate { get; set; }

    [JsonPropertyName("song_id")] public int SongId { get; set; }

    [JsonPropertyName("title")] public string? Title { get; set; }

    [JsonPropertyName("type")] public string? Type { get; set; }
}