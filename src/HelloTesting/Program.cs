var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => Results.Ok(new
{
    message = "Hello from ASP.NET Core Web API",
    framework = ".NET 8"
}));

app.MapGet("/health", () => Results.Ok(new
{
    status = "ok",
    timestamp = DateTimeOffset.UtcNow
}));

app.MapGet("/api/greetings/{name}", (string name) =>
{
    var trimmed = name?.Trim();

    if (string.IsNullOrWhiteSpace(trimmed))
    {
        return Results.BadRequest(new { message = "Name is required." });
    }

    return Results.Ok(new
    {
        message = $"Hello, {trimmed}!"
    });
});

app.Run();
