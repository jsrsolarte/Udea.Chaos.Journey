#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Udea.Chaos.Journey.Api/Udea.Chaos.Journey.Api.csproj", "Udea.Chaos.Journey.Api/"]
COPY ["Udea.Chaos.Journey.Infrastructure/Udea.Chaos.Journey.Infrastructure.csproj", "Udea.Chaos.Journey.Infrastructure/"]
COPY ["Udea.Chaos.Journey.Domain/Udea.Chaos.Journey.Domain.csproj", "Udea.Chaos.Journey.Domain/"]
COPY ["Udea.Chaos.Journey.Application/Udea.Chaos.Journey.Application.csproj", "Udea.Chaos.Journey.Application/"]
RUN dotnet restore "Udea.Chaos.Journey.Api/Udea.Chaos.Journey.Api.csproj"
COPY . .
WORKDIR "/src/Udea.Chaos.Journey.Api"
RUN dotnet build "Udea.Chaos.Journey.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Udea.Chaos.Journey.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Udea.Chaos.Journey.Api.dll"]