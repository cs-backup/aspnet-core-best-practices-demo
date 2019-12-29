FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster as build
WORKDIR /src
COPY . .
RUN dotnet restore test/WebUI.IntegrationTests/WebUI.IntegrationTests.csproj