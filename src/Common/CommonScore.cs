using DXKuma.Backend.Response;
using DXKuma.Backend.Response.Lxns;

namespace DXKuma.Backend.Data;

public class CommonScore
{
    public int Id { get; set; }

    public LxnsSongType Type { get; set; }
    
    public LevelIndex LevelIndex { get; set; }

    public float Achievements { get; set; }

    public LxnsComboType? Combo { get; set; }

    public LxnsSyncType? Sync { get; set; }

    public int DxScore { get; set; }

    public int MaxDxScore { get; set; }

    public float? Ds { get; set; }
}