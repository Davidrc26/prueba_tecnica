using dominio.entidades;
using Infraestructura.persistencia.modelos;
using System.Linq;

namespace Infraestructura.Mappers
{
    public static class ReciboMapper
    {
        public static ReciboDb ToDbModel(this Recibo dominio)
        {
            if (dominio == null) return null;

            return new ReciboDb
            {
                Id = dominio.Id,
                Estado = dominio.Estado,
                MateriaPrimaId = dominio.Suministros?.Id ?? System.Guid.Empty,
                MateriaPrima = dominio.Suministros?.ToDbModel(),
                LoteInspeccionId = dominio.Lote?.Id,
                LoteInspeccion = dominio.Lote?.ToDbModel()
            };
        }

        public static Recibo ToDomainModel(this ReciboDb modelo)
        {
            if (modelo == null) return null;

            var recibo = new Recibo(modelo.MateriaPrima?.ToDomainModel())
            {
                Estado = modelo.Estado
            };

            // Use reflection or standard way to set internal/readonly Id if necessary
            // For now assuming we can set or map them correctly

            return recibo;
        }
    }
}