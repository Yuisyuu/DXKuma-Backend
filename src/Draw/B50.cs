using DXKuma.Backend.Common;
using DXKuma.Backend.Data;
using DXKuma.Backend.ImageConfig;
using DXKuma.Backend.Response.Lxns;
using System.Text.Json;

namespace DXKuma.Backend.Draw;

public static class B50
{
    public static Task<IResult> DrawAsync(LxnsB50 b50, LxnsPlayer userInfo, string configPath)
    {
        return DrawAsync(b50.Convert(), userInfo.Convert(), configPath);
    }

    private static Task<IResult> DrawAsync(CommonB50 b50, CommonUserInfo userInfo, string configPath)
    {
        ImageBase? config = JsonSerializer.Deserialize<ImageBase>(configPath);
        throw new NotImplementedException();
    }
}