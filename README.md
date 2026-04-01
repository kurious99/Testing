# Testing

Simple ASP.NET Core Web API built with .NET 8.

## Endpoints

- `GET /` — basic info
- `GET /health` — health check
- `GET /api/greetings/{name}` — greeting endpoint

## Run locally

```bash
dotnet restore HelloTesting.sln
dotnet run --project src/HelloTesting/HelloTesting.csproj
```

## Publish

```bash
dotnet publish src/HelloTesting/HelloTesting.csproj -c Release -o publish
```
