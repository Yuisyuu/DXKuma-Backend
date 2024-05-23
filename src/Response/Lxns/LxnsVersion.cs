using System.Text.Json.Serialization;

namespace DXKuma.Backend.Response.Lxns;

public class LxnsVersion
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }
}