# Build stage
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/MyBackendApp/MyBackendApp.csproj", "MyBackendApp/"]
RUN dotnet restore "MyBackendApp/MyBackendApp.csproj"
COPY src/MyBackendApp/. MyBackendApp/
WORKDIR "/src/MyBackendApp"
RUN dotnet build "MyBackendApp.csproj" -c Release -o /app/build

# Publish stage
FROM build AS publish
RUN dotnet publish "MyBackendApp.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyBackendApp.dll"]