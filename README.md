# Varsitynest-dotnet-backend

This is a .NET backend project duplicating the functionality of varsitynest.space to demonstrate competency in the .NET tech stack.

## Setup

1. Install .NET 6 SDK.
2. Restore dependencies: `dotnet restore`
3. Build: `dotnet build`
4. Run: `dotnet run --project src/MyBackendApp/MyBackendApp.csproj`

## API Endpoints

- GET /WeatherForecast: Get weather forecasts
- GET /api/User: Get users
- GET /api/User/{id}: Get user by id

## Docker

Build and run with Docker Compose: `docker-compose up --build`

## Deployment

CI/CD pipelines are set up for GitHub Actions and Azure DevOps.

Deploy to Azure Web App or Container Instances.