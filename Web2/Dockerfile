FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Web2/Web2.csproj", "Web2/"]
RUN dotnet restore "Web2/Web2.csproj"
COPY . .
WORKDIR "/src/Web2"
RUN dotnet build "Web2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web2.dll"]