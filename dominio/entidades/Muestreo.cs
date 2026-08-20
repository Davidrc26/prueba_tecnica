using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class Muestreo
    {
        private Guid _id;
        public Guid Id { get { return _id; } }
        public string descripcion { get; set; } = string.Empty;
        public Muestreo()
        {
            _id = Guid.NewGuid();
        }
    }
}
