using System.Text.Json.Serialization;

namespace DXKuma.Backend.ImageConfig;

public class ImageTextColor
{
    [JsonPropertyName("r")]
    public int R { get; set; }

    [JsonPropertyName("g")]
    public int G { get; set; }

    [JsonPropertyName("b")]
    public int B { get; set; }

    [JsonPropertyName("a")]
    public int A { get; set; }
}