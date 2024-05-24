using System.Text.Json.Serialization;

namespace DXKuma.Backend.Response.Lxns;

public class LxnsScore
{
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("song_name")] public string? SongName { get; set; }

    [JsonPropertyName("level")] public string? Level { get; set; }

    [JsonPropertyName("level_index")] public LevelIndex LevelIndex { get; set; }

    [JsonPropertyName("achievements")] public float Achievements { get; set; }

    [JsonPropertyName("fc")] public LxnsComboType? Combo { get; set; }

    [JsonPropertyName("fs")] public LxnsSyncType? Sync { get; set; }

    [JsonPropertyName("dx_score")] public int DxScore { get; set; }

    [JsonPropertyName("dx_rating")] public float? DxRating { get; set; }

    [JsonPropertyName("rate")] public LxnsRateType? Rate { get; set; }

    [JsonPropertyName("type")] public LxnsSongType Type { get; set; }

    [JsonPropertyName("play_time")] public string? PlayTime { get; set; }

    [JsonPropertyName("upload_time")] public string? UploadTime { get; set; }
}