FROM microsoft/dotnet:1.1-runtime
ARG source
WORKDIR /app
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "ConsoleApp1.dll"]
