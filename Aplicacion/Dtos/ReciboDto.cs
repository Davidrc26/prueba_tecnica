using Aplicacion.Dtos;
using dominio.enums;

namespace Aplicacion.dtos
{
    public class ReciboDto
    {
        public Guid? Id { get; set; }
        public EstadoRecibo Estado { get; set; }
        public LoteInspeccionDto? Lote { get; set; }
        public MateriaPrimaDto? Suministros { get; set; }
    }
}