using Aplicacion.dtos;
using Aplicacion.Dtos;
using Aplicacion.Mappers.Interfaces;
using dominio.entidades;

namespace Aplicacion.Mappers.Implementaciones
{
    public class ReciboMapper : IMapper<Recibo, ReciboDto>
    {
        private readonly IMapper<LoteInspeccion, LoteInspeccionDto> _loteMapper;
        private readonly IMapper<MateriaPrima, MateriaPrimaDto> _materiaPrimaMapper;

        public ReciboMapper(
            IMapper<LoteInspeccion, LoteInspeccionDto> loteMapper,
            IMapper<MateriaPrima, MateriaPrimaDto> materiaPrimaMapper)
        {
            _loteMapper = loteMapper;
            _materiaPrimaMapper = materiaPrimaMapper;
        }

        public ReciboDto Map(Recibo source)
        {
            if (source == null) return null!;

            return new ReciboDto
            {
                Id = source.Id,
                Estado = source.Estado,
                Lote = source.Lote != null ? _loteMapper.Map(source.Lote) : null,
                Suministros = source.Suministros != null ? _materiaPrimaMapper.Map(source.Suministros) : null
            };
        }

        public Recibo MapReverse(ReciboDto destination)
        {
            if (destination == null) return null!;

            var suministros = destination.Suministros != null
                ? _materiaPrimaMapper.MapReverse(destination.Suministros)
                : null!;

            var recibo = new Recibo(suministros)
            {
                Id = destination.Id ?? Guid.NewGuid(),
                Estado = destination.Estado
            };

            if (destination.Lote != null)
            {
                recibo.Lote = _loteMapper.MapReverse(destination.Lote);
            }

            return recibo;
        }
    }
}