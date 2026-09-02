// ProveedorDto.cs
namespace Aplicacion.dtos
{
    public record ProveedorDto
    {
        public Guid ?Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
    }
}