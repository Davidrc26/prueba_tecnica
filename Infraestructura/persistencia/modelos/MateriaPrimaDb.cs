using dominio.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.persistencia.modelos
{
    public class MateriaPrimaDb
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public float Cantidad { get; set; }

        public string UnidadMedida { get; set; } = string.Empty;

        // FK
        public Guid ProveedorId { get; set; }

        // Navegación
        public ProveedorDb Proveedor { get; set; } = null!;

        public ICollection<ReciboDb> Recibos { get; set; }
            = new List<ReciboDb>();
    }
}
