using Aplicacion.dtos;
using Aplicacion.Mappers.Interfaces;
using dominio.entidades;

namespace Aplicacion.Mappers.Implementaciones
{
    public class MateriaPrimaMapper : IMapper<MateriaPrima, MateriaPrimaDto>
    {
        private readonly IMapper<Proveedor, ProveedorDto> _proveedorMapper;

        public MateriaPrimaMapper(IMapper<Proveedor, ProveedorDto> proveedorMapper)
        {
            _proveedorMapper = proveedorMapper;
        }

        public MateriaPrimaDto Map(MateriaPrima source)
        {
            if (source == null) return null!;

            return new MateriaPrimaDto
            {
                Id = source.Id,
                Nombre = source.Nombre,
                Cantidad = source.Cantidad,
                UnidadMedida = source.UnidadMedida,
                Proveedor = source.Proveedor != null ? _proveedorMapper.Map(source.Proveedor) : null
            };
        }

        public MateriaPrima MapReverse(MateriaPrimaDto destination)
        {
            if (destination == null) return null!;

            var proveedor = destination.Proveedor != null
                ? _proveedorMapper.MapReverse(destination.Proveedor)
                : null!;

            return new MateriaPrima(destination.Id, destination.Nombre, proveedor, destination.Cantidad, destination.UnidadMedida);
        }
    }
}