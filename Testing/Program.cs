using Testing;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<MyBackgroundService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
