# Define la imagen base para la construcción
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /App

# Copia los archivos .csproj de ambos proyectos
COPY ./PruebaAFP/src/PruebaAFP.API.csproj ./PruebaAFP/src/
COPY ./PruebaAFP/src/PruebaAFP.Contracts.csproj ./PruebaAFP/src/

# Restaura las dependencias
RUN dotnet restore "./src/PruebaAFP.API.csproj" --disable-parallel
RUN dotnet restore "./src/PruebaAFP.Contracts.csproj" --disable-parallel

# Copia todos los archivos al directorio de trabajo
COPY . ./

# Construye y publica la aplicación en modo Release
RUN dotnet publish "./src/PruebaAFP.API.csproj" -c Release -o out

# Define la imagen de tiempo de ejecución
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /App

# Copia los archivos publicados desde la etapa de construcción
COPY --from=build-env /App/out ./

EXPOSE 5000
# Establece el punto de entrada de la aplicación
ENTRYPOINT ["dotnet", "PruebaAFP.API.dll"]
