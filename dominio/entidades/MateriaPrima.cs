using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class MateriaPrima
    {
        private Guid _id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public Proveedor Proveedor { get; set; }

        public float Cantidad { get; set; }
        public string UnidadMedida { get; set; } = string.Empty;

        public MateriaPrima(string nombre, Proveedor proveedor, float cantidad, string unidadMedida)
        {
            _id = Guid.NewGuid();
            Nombre = nombre;
            Proveedor = proveedor;
            Cantidad = cantidad;
            UnidadMedida = unidadMedida;
        }

    }
}
