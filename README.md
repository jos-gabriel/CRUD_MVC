# CRUD MVC ASP.NET Core 6 SQL Server

## 1. Crear base de datos

- **Instalar paquetes NuGet**
  -  Microsoft.EntityFrameworkCore.SqlServer
  - Microsoft.EntityFrameworkCore.Tools

- **Models:** Crear Class Usuario
- **Data:**  Crerar Class ApplicationDbContext
- **appsettings.json:**  Agregar cadena de conexión SQL server con la nueva `Database`
- **Program:** Agregar servicio con la cadena de conexión
- **Migrar BD por Consola Administrador de paquetes:** `add-migration AgregarUsuarioBD`
- **Update BD por Consola Administrador de paquetes:** `update-database`

## 2. Agregar Controlador
- **Controllers:** Controlador de MVC con vistas que usan Entity Framework
  - Seleccionar el modelo "Usuario" y el DbContext (No mover nada más, tras aceptar se crearan los achivos para el controlador)
- **Views-Shared** Se agrega el controlador Usuarios que apunta a Usuarios-Index
- **Style bootstrap** para los botones de acción por ejemplo:  `class="btn btn-warning"`

## Imágenes del proyecto
![13581394862e3122f69d070a139fe542.png](:/bdcbf1d0a84f4d46a95b5bd04f383a99)
![41780c6800caf651d4d9247cb1cf2bd4.png](:/16f505cfc5084c168a649cf6206b95f7)