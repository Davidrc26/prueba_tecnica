using Aplicacion.dtos;
using Aplicacion.Mappers.Interfaces;
using dominio.entidades;
using System.Reflection;

namespace aplicacion.mappers
{
    public class MuestreoMapper : IMapper<Muestreo, MuestreoDto>
    {
        public MuestreoDto Map(Muestreo source)
        {
            if (source == null) return null!;

            return new MuestreoDto
            {
                Id = source.Id,
                Descripcion = source.Descripcion
            };
        }

        public Muestreo MapReverse(MuestreoDto destination)
        {
            if (destination == null) return null!;

            var muestreo = new Muestreo
            {
                Id = destination.Id,
                Descripcion = destination.Descripcion
            };



            return muestreo;
        }
    }
}