using dominio.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.persistencia.modelos
{
   
        public class ReciboDb
        {
            public Guid Id { get; set; }

            public EstadoRecibo Estado { get; set; }

            // FK
            public Guid MateriaPrimaId { get; set; }

            public Guid? LoteInspeccionId { get; set; }

            // Navegaciones
            public MateriaPrimaDb MateriaPrima { get; set; } = null!;
            public LoteInspeccionDb? LoteInspeccion { get; set; }
        }
    
}
