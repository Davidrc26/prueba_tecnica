using dominio.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.dtos
{
    public record LoteInspeccionDto
    {
        public List<MuestreoDto> Muestreos { get; set; }

        public LoteInspeccionDto(MuestreoDto muestreo)
        {
            Muestreos = new List<MuestreoDto> { muestreo };
        }


    }
}
