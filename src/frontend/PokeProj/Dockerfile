# FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim AS base
# WORKDIR /app
# EXPOSE 80
# EXPOSE 443

# FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build
# WORKDIR /app

# RUN apt-get update && \
#   apt-get upgrade -y && \
#   apt-get install -y procps

# COPY "PokeProj/PokeProj.csproj" "PokeProj/PokeProj.csproj"
# RUN dotnet restore

# COPY . .
# WORKDIR /app/PokeProj
# RUN dotnet publish -c Release

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app .
# ENTRYPOINT ["dotnet", "PokeProj.dll"]

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY "PokeProj/PokeProj.csproj" "PokeProj/PokeProj.csproj"
RUN dotnet restore
COPY . .
RUN dotnet build -c Release -o /app/build

FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/PokeProj/dist .
COPY nginx.conf /etc/nginx/nginx.conf