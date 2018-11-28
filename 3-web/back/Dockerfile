# Build runtime image
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY  /src/out .
ENTRYPOINT ["dotnet", "src.dll"]