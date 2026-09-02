using Aplicacion.dtos;
using Aplicacion.Mappers.Interfaces;
using dominio.entidades;

namespace Aplicacion.Mappers.Implementaciones
{
    public class ProveedorMapper : IMapper<Proveedor, ProveedorDto>
    {
        public ProveedorDto Map(Proveedor source)
        {
            if (source == null) return null!;

            return new ProveedorDto
            {
                Id = source.Id,
                Nombre = source.Nombre,
                Nit = source.Nit
            };
        }

        public Proveedor MapReverse(ProveedorDto destination)
        {
            if (destination == null) return null!;

            return new Proveedor(destination.Id, destination.Nombre, destination.Nit);
        }
    }
}