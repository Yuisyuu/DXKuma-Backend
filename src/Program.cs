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
        string? key = app.Configuration["Lxns.Key"];
        if (key is null)
        {
            return Results.StatusCode(404);
        }
        LxnsProber prober = new(qq, key);
        LxnsB50 b50 = await prober.GetB50Async();
        IResult img = await b50.DrawAsync();
        return img;
    })
    .WithName("DXKuma")
    .WithOpenApi();

app.Run();