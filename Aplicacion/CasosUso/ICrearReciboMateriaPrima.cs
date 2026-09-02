using Aplicacion.dtos;
using dominio.entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.CasosUso
{
    public interface ICrearReciboMateriaPrima
    {
        public Task<ReciboDto> CrearReciboMateriaPrima(ReciboDto request);
    }
}
