#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["govuk-admin-portal/govuk-admin-portal.csproj", "govuk-admin-portal/"]
RUN dotnet restore "govuk-admin-portal/govuk-admin-portal.csproj"
COPY . .
WORKDIR "/src/govuk-admin-portal"
RUN dotnet build "govuk-admin-portal.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "govuk-admin-portal.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "govuk-admin-portal.dll"]