# ToDoApi

API simple de ejemplo para gestionar una lista de tareas (To-Do) creada con .NET 9.

## Descripción

Este repositorio contiene una API REST y una pequeña interfaz estática en `wwwroot` para crear, leer, actualizar y eliminar tareas. El objetivo del README es permitir a cualquier persona clonar el repositorio, ejecutar la API localmente y probar los endpoints con `curl`, Postman o la interfaz web incluida.

## Requisitos

- .NET 9 SDK instalado (https://dotnet.microsoft.com).
- Git (para clonar el repositorio).
- Navegador web para probar la interfaz en `wwwroot/index.html`.

Opcional:
- Visual Studio 2022 o Visual Studio Code.

## Ejecutar localmente

Desde la raíz del repositorio:

# Restaurar paquetes
dotnet restore

# Compilar
dotnet build

# Ejecutar el proyecto (reemplaza el nombre del proyecto si difiere)
dotnet run --project ToDoApi


# Alternativa: 
abrir la solución en Visual Studio y usar __Debug > Start Debugging__ o __Debug > Start Without Debugging__.

Por defecto, la aplicación expondrá endpoints en http(s). Observa la consola para ver el puerto exacto (o revisa `Properties/launchSettings.json`).

## Probar la interfaz web

La carpeta `wwwroot` contiene una interfaz mínima. Una vez ejecutada la aplicación, abre en el navegador:

`http://localhost:{PORT}/`  o `https://localhost:{PORT}/` (reemplaza `{PORT}` con el puerto que aparece en la consola).

La página carga `wwwroot/index.html` y usa `wwwroot/js/site.js` para consumir la API en `api/todoitems`.

## Endpoints

Base: `/api/todoitems`

- GET `/api/todoitems` — Devuelve todas las tareas.
- GET `/api/todoitems/{id}` — Devuelve una tarea por id.
- POST `/api/todoitems` — Crea una tarea. Body JSON: `{ "name": "Texto", "isComplete": false }`.
- PUT `/api/todoitems/{id}` — Actualiza una tarea completa. Body JSON: `{ "id": 1, "name": "Texto", "isComplete": true }`.
- DELETE `/api/todoitems/{id}` — Elimina una tarea.

> Nota: Revisa el controlador si la ruta base difiere (por ejemplo, por atributos en el código).
