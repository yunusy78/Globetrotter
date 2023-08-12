FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Globetrotter/Globetrotter.csproj", "Globetrotter/"]
RUN dotnet restore "Globetrotter/Globetrotter.csproj"
COPY . .
WORKDIR "/src/Globetrotter"
RUN dotnet build "Globetrotter.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Globetrotter.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Globetrotter.dll"]
