using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.dtos
{
    public record ReciboDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public LoteInspeccionDto Lote { get; set; }
     

    }
}
