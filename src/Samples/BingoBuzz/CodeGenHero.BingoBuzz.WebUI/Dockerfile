FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 50388
EXPOSE 44350

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY CodeGenHero.BingoBuzz.WebUI/CodeGenHero.BingoBuzz.WebUI.csproj CodeGenHero.BingoBuzz.WebUI/
RUN dotnet restore CodeGenHero.BingoBuzz.WebUI/CodeGenHero.BingoBuzz.WebUI.csproj
COPY . .
WORKDIR /src/CodeGenHero.BingoBuzz.WebUI
RUN dotnet build CodeGenHero.BingoBuzz.WebUI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish CodeGenHero.BingoBuzz.WebUI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CodeGenHero.BingoBuzz.WebUI.dll"]
