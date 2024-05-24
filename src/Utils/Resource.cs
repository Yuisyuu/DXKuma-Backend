using LiteDB;

namespace DXKuma.Backend.Utils;

public static class Resource
{
    private const string BaseUrl = "https://assets2.lxns.net/maimai";

    private const string CacheDirPath = "Cache";

    private static readonly LiteDatabase s_db;

    static Resource()
    {
        if (!Directory.Exists(CacheDirPath))
        {
            Directory.CreateDirectory(CacheDirPath);
        }

        s_db = new("Cache.db");
    }

    private static Task<bool> CheckAvailableCacheAsync(string type, int id)
    {
        string path = Path.Combine(type, $"{id}.png");
        string fullPath = Path.Combine(CacheDirPath, path);
        if (!File.Exists(fullPath))
        {
            return Task.FromResult(false);
        }

        ILiteCollection<Cache> col = s_db.GetCollection<Cache>(type);
        Cache cache = col.FindById(id);
        if (cache is not null && DateTime.UtcNow - cache.CacheTime < TimeSpan.FromDays(1))
        {
            return Task.FromResult(true);
        }

        File.Delete(fullPath);
        return Task.FromResult(false);
    }

    private static async Task<byte[]> GetAsync(string type, int id)
    {
        string dirPath = Path.Combine(CacheDirPath, type);
        string path = Path.Combine(dirPath, $"{id}.png");
        if (await CheckAvailableCacheAsync(type, id))
        {
            return await File.ReadAllBytesAsync(path);
        }

        using HttpClient httpClient = new();
        byte[] img = await httpClient.GetByteArrayAsync($"{BaseUrl}/{type}/{id}.png");
        if (!Directory.Exists(dirPath))
        {
            Directory.CreateDirectory(dirPath);
        }

        await File.WriteAllBytesAsync(path, img);
        return img;
    }

    public static async Task<byte[]> GetIconAsync(int id)
    {
        return await GetAsync("icon", id);
    }

    public static async Task<byte[]> GetPlateAsync(int id)
    {
        return await GetAsync("plate", id);
    }

    public static async Task<byte[]> GetJacketAsync(int id)
    {
        return await GetAsync("jacket", id);
    }

    private class Cache
    {
        public int Id { get; set; }
        public DateTime CacheTime { get; set; }
    }
}