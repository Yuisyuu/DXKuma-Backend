using DXKuma.Backend.Data;
using System.Text.Json.Serialization;

namespace DXKuma.Backend.Response.Lxns;

public class LxnsB50
{
    [JsonPropertyName("standard_total")]
    public int StandardTotal { get; set; }
    
    [JsonPropertyName("dx_total")]
    public int DxTotal { get; set; }
    
    [JsonPropertyName("standard")]
    public LxnsScore[]? Standard { get; set; }
    
    [JsonPropertyName("dx")]
    public LxnsScore[]? Dx { get; set; }

    public CommonB50 Convert()
    {
        var b50 = new CommonB50
        {
            Standard = [],
            Dx = []
        };
        foreach (var score in Standard!)
        {
            var commonScore = new CommonScore
            {
                Id = score.Id,
                Achievements = score.Achievements,
                Combo = score.Combo,
                Ds = 0,
                DxScore = score.DxScore,
                MaxDxScore = 0,
                LevelIndex = score.LevelIndex,
                Sync = score.Sync,
                Type = score.Type
            };
            b50.Standard.Add(commonScore);
        }
        foreach (var score in Dx!)
        {
            var commonScore = new CommonScore
            {
                Id = score.Id,
                Achievements = score.Achievements,
                Combo = score.Combo,
                Ds = 0,
                DxScore = score.DxScore,
                MaxDxScore = 0,
                LevelIndex = score.LevelIndex,
                Sync = score.Sync,
                Type = score.Type
            };
            b50.Dx.Add(commonScore);
        }

        return b50;
    }
}
