FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
 
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /app

RUN apt-get update && \
  apt-get upgrade -y && \
  apt-get install -y procps

COPY "Bomp.Api/Bomp.Api.csproj" "Bomp.Api/Bomp.Api.csproj"
RUN dotnet restore
 
COPY . .
WORKDIR /app/Bomp.Api
RUN dotnet publish -c Release
 
FROM base AS final
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Bomp.Api.dll"]