using DXKuma.Backend.Draw;
using DXKuma.Backend.Prober;
using DXKuma.Backend.Response.Lxns;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/b50/Lxns/{qq}", async (string qq) =>
    {
        string? key = app.Configuration["Key.Lxns"];
        if (key is null)
        {
            return Results.StatusCode(404);
        }

        LxnsProber prober = new(qq, key);
        LxnsB50 b50 = await prober.GetB50Async();
        LxnsPlayer userInfo = await prober.GetUserInfoAsync();
        IResult img = await B50.DrawAsync(b50, userInfo);
        return img;
    })
    .WithName("DXKuma")
    .WithOpenApi();

app.Run();