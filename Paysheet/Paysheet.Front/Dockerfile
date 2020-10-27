FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Paysheet.Front/Paysheet.Front.csproj", "Paysheet.Front/"]
RUN dotnet restore "Paysheet.Front/Paysheet.Front.csproj"
COPY . .
WORKDIR "/src/Paysheet.Front"
RUN dotnet build "Paysheet.Front.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Paysheet.Front.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Paysheet.Front.dll"]