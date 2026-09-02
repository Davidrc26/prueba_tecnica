using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class MateriaPrima
    {
        public Guid Id {  get; set; }
        public string Nombre { get; set; } = string.Empty;
        public Proveedor Proveedor { get; set; }

        public float Cantidad { get; set; }
        public string UnidadMedida { get; set; } = string.Empty;

        public MateriaPrima(Guid? id, string nombre, Proveedor proveedor, float cantidad, string unidadMedida)
        {
            Id = id ?? Guid.NewGuid();
            Nombre = nombre;
            Proveedor = proveedor;
            Cantidad = cantidad;
            UnidadMedida = unidadMedida;
        }

    }
}
