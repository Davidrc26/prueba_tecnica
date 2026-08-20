using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.persistencia.modelos
{
    public class ProveedorDb
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Nit { get; set; } = string.Empty;

        public ICollection<MateriaPrimaDb> MateriasPrimas { get; set; }
            = new List<MateriaPrimaDb>();
    }
}
