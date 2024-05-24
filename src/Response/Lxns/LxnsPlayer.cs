using DXKuma.Backend.Common;
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
    public LxnsCollection? Icon { get; set; }
    
    [JsonPropertyName("name_plate")]
    public LxnsCollection? NamePlate { get; set; }
    
    [JsonPropertyName("frame")]
    public LxnsCollection? Frame { get; set; }
    
    [JsonPropertyName("upload_time")]
    public string? UploadTime { get; set; }

    public CommonUserInfo Convert()
    {
        return new()
        {
            ClassRank = ClassRank,
            CourseRank = CourseRank,
            FrameId = Frame?.Id ?? 0,
            IconId = Icon?.Id ?? 0,
            Name = Name,
            NamePlateId = NamePlate?.Id ?? 0
        };
    }
}