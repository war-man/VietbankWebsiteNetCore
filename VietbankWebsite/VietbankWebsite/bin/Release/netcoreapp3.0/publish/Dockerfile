FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-stretch-slim AS base
WORKDIR /app
COPY . .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet VietbankWebsite.dll