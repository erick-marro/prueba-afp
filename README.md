# Prueba técnica APF Crecer
by Erick Marroquín

Requisitos de la solución
- Crear empresas
- Obtener empresa por ID
- Crear Departamento
- Obtener departamento por empresa

La documentación de la API se encuentra en la carpeta ```Docs```.

Para el desarrollo de la solución se alojó una base de SQL server en un contenedor de docker, es solo para testing. La solución utiliza principios SOLID y una implementación de la arquitectura DDD.

## Instrucciones
- Clone el repositorio en la carpeta deseada
- Mediante ```docker compose up``` levante la base de datos
- Ejecute las dos migraciones que se encuentran en el proyecto
- La solución puede levantarse mediante la terminal y ```dotnet cli``` o directamente al ejecutar en visual studio