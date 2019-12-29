web:
	@cd src/WebUI/ClientApp/; npm start

api:
	@cd src/WebUI/; dotnet run

dev:
	@cd src/WebUI/; dotnet watch run

db:
	@docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=P@ssw0rd" \
   -p 1433:1433 --name sql1 \
   -d mcr.microsoft.com/mssql/server:2019-GA-ubuntu-16.04

setup:
	@dotnet restore
	@dotnet build
	@cd src/WebUI/ClientApp/; npm install

test: 
	@dotnet test