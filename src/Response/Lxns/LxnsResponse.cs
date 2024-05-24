using System.Text.Json.Serialization;

namespace DXKuma.Backend.Response.Lxns;

public class LxnsResponse<T>
{
    [JsonPropertyName("success")] public bool Success { get; set; }

    [JsonPropertyName("code")] public int Code { get; set; }

    [JsonPropertyName("message")] public string? Message { get; set; }

    [JsonPropertyName("data")] public T? Data { get; set; }
}