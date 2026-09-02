using dominio.entidades;
using Infraestructura.persistencia.modelos;

namespace Infraestructura.Mappers
{
    public static class MateriaPrimaMapper
    {
        public static MateriaPrimaDb ToDbModel(this MateriaPrima dominio)
        {
            if (dominio == null) return null;

            return new MateriaPrimaDb
            {
                Id = dominio.Id,
                Nombre = dominio.Nombre,
                Cantidad = dominio.Cantidad,
                UnidadMedida = dominio.UnidadMedida,
                ProveedorId = dominio.Proveedor?.Id ?? System.Guid.Empty,
                Proveedor = dominio.Proveedor?.ToDbModel()
            };
        }

        public static MateriaPrima ToDomainModel(this MateriaPrimaDb modelo)
        {
            if (modelo == null) return null;

            return new MateriaPrima(
                modelo.Id,
                modelo.Nombre,
                modelo.Proveedor?.ToDomainModel(),
                modelo.Cantidad,
                modelo.UnidadMedida
            );
        }
    }
}