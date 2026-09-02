using dominio.entidades;
using Infraestructura.persistencia.modelos;

namespace Infraestructura.Mappers
{
    public static class ProveedorMapper
    {
        public static ProveedorDb ToDbModel(this Proveedor dominio)
        {
            if (dominio == null) return null;

            return new ProveedorDb
            {
                Id = dominio.Id,
                Nombre = dominio.Nombre,
                Nit = dominio.Nit
            };
        }

        public static Proveedor ToDomainModel(this ProveedorDb modelo)
        {
            if (modelo == null) return null;

            return new Proveedor(
                modelo.Id,
                modelo.Nombre,
                modelo.Nit
            );
        }
    }
}