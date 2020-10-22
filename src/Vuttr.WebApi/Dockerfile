#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Vuttr.WebApi/Vuttr.WebApi.csproj", "src/Vuttr.WebApi/"]
RUN dotnet restore "src/Vuttr.WebApi/Vuttr.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Vuttr.WebApi"
RUN dotnet build "Vuttr.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Vuttr.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Vuttr.WebApi.dll"]