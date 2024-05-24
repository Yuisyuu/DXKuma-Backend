using System.Text.Json.Serialization;

namespace DXKuma.Backend.ImageConfig;

public class ImageSize
{
    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }
}