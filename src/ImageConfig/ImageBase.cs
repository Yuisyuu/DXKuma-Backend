using System.Text.Json.Serialization;

namespace DXKuma.Backend.ImageConfig;

public class ImageBase
{
    [JsonPropertyName("background")]
    public string Background { get; set; }

    [JsonPropertyName("parts")]
    public ImagePart[] Parts { get; set; }
}