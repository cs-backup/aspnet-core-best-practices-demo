FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
# Install Node.Js
RUN apt-get update -yq 
RUN apt-get install curl gnupg -yq 
RUN curl -sL https://deb.nodesource.com/setup_12.x | bash -
RUN apt-get install -y nodejs

#Install Angular CLI
RUN npm install -g @angular/cli@8.2.2

WORKDIR /src

COPY ["src/WebUI/WebUI.csproj", "src/WebUI/"]
RUN dotnet restore "src/WebUI/WebUI.csproj"
COPY . .
WORKDIR /src/src/WebUI
RUN dotnet build "WebUI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "WebUI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Northwind.WebUI.dll"]