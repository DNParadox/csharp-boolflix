// Installazione pacchetto NuGet
	* dotnet add package System.Data.SqlClient


// Pacchetto EF SqlServer
	* dotnet add package Microsoft.EntityFrameworkCore.SqlServer

// Pacchetto EF Core Design
	* dotnet add package Microsoft.EntityFrameworkCore.Design

// Pacchetto Globale Dotnet (E)ntity (F)ramework (Necessario soltanto 1 volta ad ogni installazione di VS)
	* dotnet tool install --global dotnet-ef

// Pacchetto Razor Page
	* dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation -v=6

// Da inserire all'interno di Program.cs sotto "AddControllerWithViews" per autoaggiornamento Pagine Web
	* builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

// Entity Framework Core
	* dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore

// Identity UI
	* dotnet add package Microsoft.AspNetCore.Identity.UI --version=6.0

// Code Generation Design
	* dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version=6.0








// Per creare una Migration
	* dotnet ef mimgrations add "NomeMigration"

// Per Aggiornare una Migration
	* dotnet ef database update

