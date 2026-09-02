using dominio.entidades;
using Infraestructura.persistencia.modelos;
using System.Linq;

namespace Infraestructura.Mappers
{
    public static class LoteInspeccionMapper
    {
        public static LoteInspeccionDb ToDbModel(this LoteInspeccion dominio)
        {
            if (dominio == null) return null;

            return new LoteInspeccionDb
            {
                Id = dominio.Id,
                Estado = dominio.Estado
            };
        }

        public static LoteInspeccion ToDomainModel(this LoteInspeccionDb modelo)
        {
            if (modelo == null) return null;

            return new LoteInspeccion
            {
                Id = modelo.Id,
                Estado = modelo.Estado
            };
        }
    }
}