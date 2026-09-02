using Aplicacion.dtos;
using dominio.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Dtos
{
    public record LoteInspeccionDto
    {
        public Guid? Id { get; set; }
        public EstadoLote Estado { get; set; }
        public List<MuestreoDto> Muestreos { get; set; } = new();
    }
}
