using DXKuma.Backend.Utils;
using System.Text.Json.Serialization;

namespace DXKuma.Backend.ImageConfig;

public class ImagePart
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("pos")]
    public ImagePos? Pos { get; set; }

    [JsonPropertyName("size")]
    public Possible<ImageSize, int>? Size { get; set; }
}