using dominio.entidades;
using dominio.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace dominio.interfaces.repositorios
{
    public interface IReciboRepositorio
    {
        public Task<Recibo> IngresarRecibo(Recibo recibo);
        public Task<Recibo> ObtenerDetalleRecibo(Guid id);
        public Task<List<Recibo>> ObtenerRecibos();
        public Task CambiarEstado(EstadoRecibo estado, Guid id);

    }
}
