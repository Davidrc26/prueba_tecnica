using dominio.dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.interfaces.repositorios
{
    public interface IMuestraRepositorio
    {
        public Task AgregarMuestra(MuestraDto muestra);
    }
}
