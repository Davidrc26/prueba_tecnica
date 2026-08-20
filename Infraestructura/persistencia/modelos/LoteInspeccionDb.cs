using dominio.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.persistencia.modelos
{
    public class LoteInspeccionDb
    {
        public Guid Id { get; set; }

        public EstadoLote Estado { get; set; }

        public ReciboDb? Recibo { get; set; }

        public ICollection<MuestreoDb> Muestreos { get; set; }
            = new List<MuestreoDb>();
    }
}
