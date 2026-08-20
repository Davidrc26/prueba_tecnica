# Arquitectura del Proyecto

Este proyecto sigue los principios de la **Arquitectura Limpia (Clean Architecture)** / **Arquitectura Hexagonal (Puertos y Adaptadores)**, dividiendo las responsabilidades en diferentes capas (proyectos) para lograr un sistema altamente desacoplado, mantenible y testeable.

## Estructura de Capas (Proyectos)

### 1. Dominio (`dominio.csproj`)
Es el corazón de la aplicación. No tiene dependencias con ninguna otra capa. 
- **Entidades (`entidades/`)**: Modelos de dominio que representan las reglas de negocio (ej. `Recibo`, `LoteInspeccion`).
- **Interfaces (`interfaces/`)**: Contratos que otras capas deben implementar, como las interfaces de los repositorios (`IReciboRepositorio.cs`).
- **DTOs (`dtos/`)**: Objetos de transferencia de datos utilizados para enviar o recibir información (ej. `MuestraDto.cs`).

### 2. Aplicación (`Aplicacion.csproj`)
Responsable de orquestar las operaciones del negocio (Casos de uso). 
- Depende únicamente de la capa de **Dominio**.
- Aquí se pueden encontrar los servicios de aplicación, lógica que coordina las entidades y los repositorios, mapeos (ej. AutoMapper) y validaciones de entrada.

### 3. Infraestructura (`Infraestructura.csproj`)
Proporciona las implementaciones concretas para las interfaces definidas en la capa de Dominio. 
- Depende de las capas de **Dominio** y **Aplicación**.
- **Persistencia**: Incluye la configuración de base de datos usando Entity Framework Core (`AppDbContext.cs`), así como las clases que implementan los repositorios (`ReciboRepositorio.cs`) interactuando con la base de datos real.

### 4. Presentación / API (`prueba_tecnica.csproj`)
Es el punto de entrada a la aplicación. En este caso un proyecto ASP.NET Core Web API.
- Depende de todas las capas anteriores para poder inicializar el sistema (Inyección de Dependencias).
- **Controladores (`Controllers/`)**: Exponen los endpoints HTTP para interactuar con los casos de uso (capa de Aplicación).
- **Configuración (`Program.cs` / `appsettings.json`)**: Configuración de los servicios de inyección de dependencias, base de datos y middlewares de la API.

## Flujo de Comunicación
1. La **API** recibe una petición HTTP a través de un controlador.
2. El controlador delega la ejecución a un **Servicio de Aplicación (Caso de Uso)** pasando típicamente un *DTO*.
3. El servicio de aplicación utiliza las **Interfaces del repositorio (Dominio)** para obtener **Entidades**.
4. Detrás de escena, la **Infraestructura** ejecuta la consulta en la base de datos y devuelve la entidad.
5. El servicio aplica lógica de negocio y guarda cambios utilizando de nuevo el repositorio.
6. La API devuelve al cliente el resultado u otro DTO.

## Ventajas de este enfoque
- **Independencia de Frameworks:** La lógica de negocio no está atada a Entity Framework, ASP.NET o cualquier UI.
- **Testeabilidad:** Las reglas de negocio son fáciles de probar (Unit Tests) haciendo *mocks* de las interfaces.
- **Mantenibilidad:** El código está claramente organizado por responsabilidad. Cambiar de base de datos o actualizar un paquete no afecta al modelo central.