FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine3.18

WORKDIR /app
EXPOSE 8080

COPY /bin/Release/net8.0 .
ENTRYPOINT ["dotnet", "L53_WebApi.dll"]