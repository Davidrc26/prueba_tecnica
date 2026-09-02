using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class Muestreo
    {
        public Guid Id { get; set; }
       
        public string Descripcion { get; set; } = string.Empty;
        public Muestreo()
        {
            Id = Guid.NewGuid();
        }
    }
}
