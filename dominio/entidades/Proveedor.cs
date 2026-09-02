using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class Proveedor
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
        public Proveedor(Guid? id, string nombre, string nit)
        {
            Id = id ?? Guid.NewGuid();
            Nombre = nombre;
            Nit = nit;
        }
    }
}
