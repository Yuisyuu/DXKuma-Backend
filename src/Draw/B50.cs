using DXKuma.Backend.Common;
using DXKuma.Backend.Data;
using DXKuma.Backend.Response.Lxns;

namespace DXKuma.Backend.Draw;

public static class B50
{
    public static Task<IResult> DrawAsync(this LxnsB50 b50)
    {
        return DrawAsync(b50.Convert(), null);
    }
    private static Task<IResult> DrawAsync(CommonB50 b50, CommonUserInfo userInfo)
    {
        throw new NotImplementedException();
    }
}