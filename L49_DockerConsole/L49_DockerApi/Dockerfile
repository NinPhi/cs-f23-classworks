FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine3.18
WORKDIR /app
COPY ./bin/Debug/net8.0 .
EXPOSE 8080
ENTRYPOINT ["dotnet", "./L49_DockerApi.dll"]