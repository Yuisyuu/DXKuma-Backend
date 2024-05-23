using System.Text.Json.Serialization;

namespace DXKuma.Backend.Response.Lxns;

public class LxnsPlayer
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("rating")]
    public int Rating { get; set; }
    
    [JsonPropertyName("friend_code")]
    public long FriendCode { get; set; }
    
    [JsonPropertyName("trophy")]
    public LxnsCollection? Trophy { get; set; }
    
    [JsonPropertyName("trophy_name")]
    public string? TrophyName { get; set; }
    
    [JsonPropertyName("course_rank")]
    public int CourseRank { get; set; }
    
    [JsonPropertyName("class_rank")]
    public int ClassRank { get; set; }
    
    [JsonPropertyName("star")]
    public int Star { get; set; }
    
    [JsonPropertyName("icon")]
    public LxnsIcon? Icon { get; set; }
    
    [JsonPropertyName("name_plate")]
    public LxnsNamePlate? NamePlate { get; set; }
    
    [JsonPropertyName("frame")]
    public LxnsFrame? Frame { get; set; }
    
    [JsonPropertyName("upload_time")]
    public string? UploadTime { get; set; }
}