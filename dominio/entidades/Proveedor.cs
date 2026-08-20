using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class Proveedor
    {
        private Guid _id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Nit { get; set; } = string.Empty;
        public Proveedor(string nombre, string nit)
        {
            _id = Guid.NewGuid();
            Nombre = nombre;
            Nit = nit;
        }
    }
}
