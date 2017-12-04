FROM microsoft/dotnet:2.0.0-runtime
WORKDIR /dotnetapp
COPY ./bin/Docker .
ENV ASPNETCORE_ENVIRONMENT docker
ENTRYPOINT dotnet Trader.Server.dll --urls "http://*:5000"