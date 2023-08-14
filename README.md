[![LinkedIn][linkedin-shield]][linkedin-url]

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
![Index](https://github.com/jos-gabriel/CRUD_MVC/assets/65365848/8b84f8eb-1842-4884-bcc7-4895973b763e)
![Crear_usuario](https://github.com/jos-gabriel/CRUD_MVC/assets/65365848/6aeae5a4-bae7-42a7-bcf0-67d2e2e68688)


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/jos-hdz/
