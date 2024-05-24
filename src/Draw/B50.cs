using DXKuma.Backend.Common;
using DXKuma.Backend.Data;
using DXKuma.Backend.Response.Lxns;

namespace DXKuma.Backend.Draw;

public static class B50
{
    public static Task<IResult> DrawAsync(LxnsB50 b50, LxnsPlayer userInfo)
    {
        return DrawAsync(b50.Convert(), userInfo.Convert());
    }
    private static Task<IResult> DrawAsync(CommonB50 b50, CommonUserInfo userInfo)
    {
        throw new NotImplementedException();
    }
}