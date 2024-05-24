using System.Text.Json.Serialization;

namespace DXKuma.Backend.ImageConfig;

public class ImagePos
{
    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }
}