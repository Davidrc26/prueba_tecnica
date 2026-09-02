# Instrucciones de Ejecución

Este documento describe los pasos necesarios para configurar y ejecutar el proyecto localmente.

## Prerrequisitos

- **.NET 10 SDK** o superior instalados en la máquina.
- **Visual Studio Community 2026** (o cualquier editor compatible con .NET 10).
- Configuración de base de datos (Ej., LocalDB o SQL Server) dependiendo de cómo esté configurada la cadena de conexión.
- **Git** instalado.

## 1. Clonar el repositorio

Abre una terminal y ejecuta el siguiente comando:

```bash
git clone https://github.com/Davidrc26/prueba_tecnica.git
cd prueba_tecnica
```

## 2. Restaurar dependencias

Puedes restaurar las dependencias abriendo la solución (`prueba_tecnica.slnx`) directamente en Visual Studio (lo hará automáticamente) o ejecutando el siguiente comando en la raíz del proyecto:

```bash
dotnet restore
```

## 3. Configuración de Base de Datos (Entity Framework Core)

Para reflejar los modelos en tu base de datos local, necesitas aplicar las migraciones.

1. Verifica la cadena de conexión en el archivo `prueba_tecnica/appsettings.json` o `prueba_tecnica/appsettings.Development.json`.
2. Ejecuta la migración de la base de datos:

**Usando la .NET CLI:**
```bash
dotnet ef database update --project Infraestructura\Infraestructura.csproj --startup-project prueba_tecnica\prueba_tecnica.csproj
```

**O usando la "Consola del Administrador de paquetes" en Visual Studio:**
1. Selecciona `Infraestructura` como "Proyecto predeterminado" en el menú desplegable.
2. Ejecuta el comando:
```powershell
Update-Database
```

## 4. Ejecución del Proyecto

### Opción A: Usando Visual Studio (Recomendado)
1. Abre el archivo de solución `prueba_tecnica.slnx`.
2. En el Explorador de soluciones, asegúrate de que el proyecto `prueba_tecnica` (la API Web) está marcado como **Proyecto de inicio** (Startup Project). 
3. Presiona **F5** para iniciar con depuración o **Ctrl + F5** sin depuración.
4. Se abrirá tu navegador predeterminado apuntando a la URL del puerto configurado (normalmente verás la interfaz de Swagger si está configurado).

### Opción B: Usando la .NET CLI
Ejecuta el siguiente comando desde la raíz del proyecto en tu terminal:

```bash
dotnet run --project prueba_tecnica\prueba_tecnica.csproj
```

Revisa la salida de la consola para ver qué URL local se le ha asignado a la aplicación (ej. `https://localhost:7xxx`) y ábrela en tu navegador (añade `/swagger` a la ruta si estás utilizando OpenAPI).
