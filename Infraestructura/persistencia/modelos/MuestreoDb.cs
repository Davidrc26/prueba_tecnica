using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.persistencia.modelos
{
    public class MuestreoDb
    {
        public Guid Id { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public Guid LoteInspeccionId { get; set; }

        public LoteInspeccionDb LoteInspeccion { get; set; } = null!;
    }
}
