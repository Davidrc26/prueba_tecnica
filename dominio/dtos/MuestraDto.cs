using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.dtos
{
    public record MuestraDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid LoteId { get; set; }

    }
}
