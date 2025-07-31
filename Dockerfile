FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="1.0" \
      description="Aplicação ASP .NET CORE MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "mvc-com-docker.dll"]


