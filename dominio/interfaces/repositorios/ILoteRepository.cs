using dominio.dtos;
using dominio.enums;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace dominio.interfaces.repositorios
{
    public interface ILoteRepository
    {
      public Task AprobarLote(Guid id, EstadoLote estado);
    }
}
