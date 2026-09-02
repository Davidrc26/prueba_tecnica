// MateriaPrimaDto.cs

namespace Aplicacion.dtos
{
    public record MuestreoDto
    {
        public Guid? Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
    }
}