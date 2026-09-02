
namespace Aplicacion.dtos
{
    public record MateriaPrimaDto
    {
        public Guid? Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public ProveedorDto? Proveedor { get; set; }
        public float Cantidad { get; set; }
        public string UnidadMedida { get; set; } = string.Empty;
    }
}