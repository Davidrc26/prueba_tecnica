using Aplicacion.dtos;
using Aplicacion.Dtos;
using Aplicacion.Mappers.Interfaces;
using dominio.entidades;

namespace Aplicacion.Mappers.Implementaciones
{
    public class LoteInspeccionMapper : IMapper<LoteInspeccion, LoteInspeccionDto>
    {
        private readonly IMapper<Muestreo, MuestreoDto> _muestreoMapper;

        public LoteInspeccionMapper(IMapper<Muestreo, MuestreoDto> muestreoMapper)
        {
            _muestreoMapper = muestreoMapper;
        }

        public LoteInspeccionDto Map(LoteInspeccion source)
        {
            if (source == null) return null!;

            return new LoteInspeccionDto
            {
                Id = source.Id,
                Estado = source.Estado,
                Muestreos = source.Muestreos?.Select(_muestreoMapper.Map).ToList() ?? new List<MuestreoDto>()
            };
        }

        public LoteInspeccion MapReverse(LoteInspeccionDto destination)
        {
            if (destination == null) return null!;

            var lote = new LoteInspeccion
            {
                Id = destination.Id ?? Guid.NewGuid(),
                Estado = destination.Estado
            };

            if (destination.Muestreos != null)
            {
                foreach (var muestreoDto in destination.Muestreos)
                {
                    lote.Muestreos.Add(_muestreoMapper.MapReverse(muestreoDto));
                }
            }

            return lote;
        }
    }
}