# Prueba t�cnica APF Crecer
by Erick Marroqu�n

Requisitos de la soluci�n
- Crear empresas
- Obtener empresa por ID
- Crear Departamento
- Obtener departamento por empresa

La documentaci�n de la API se encuentra en la carpeta ```Docs```.

Para el desarrollo de la soluci�n se aloj� una base de SQL server en un contenedor de docker, es solo para testing. La soluci�n utiliza principios SOLID y una implementaci�n de la arquitectura DDD.

## Instrucciones
- Clone el repositorio en la carpeta deseada
- Mediante ```docker compose up``` levante la base de datos
- Ejecute las dos migraciones que se encuentran en el proyecto
- La soluci�n puede levantarse mediante la terminal y ```dotnet cli``` o directamente al ejecutar en visual studio