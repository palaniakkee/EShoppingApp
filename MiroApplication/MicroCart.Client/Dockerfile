#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MicroCart.Client/MicroCart.Client.csproj", "MicroCart.Client/"]
RUN dotnet restore "MicroCart.Client/MicroCart.Client.csproj"
COPY . .
WORKDIR "/src/MicroCart.Client"
RUN dotnet build "MicroCart.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MicroCart.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MicroCart.Client.dll"]