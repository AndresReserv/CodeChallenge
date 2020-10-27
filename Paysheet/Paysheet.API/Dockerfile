FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Paysheet.API/Paysheet.API.csproj", "Paysheet.API/"]
RUN dotnet restore "Paysheet.API/Paysheet.API.csproj"
COPY . .
WORKDIR "/src/Paysheet.API"
RUN dotnet build "Paysheet.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Paysheet.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Paysheet.API.dll"]