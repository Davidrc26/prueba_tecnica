using dominio.dtos;
using dominio.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace dominio.interfaces.repositorios
{
    public interface IReciboRepositorio
    {
        public Task<ReciboDto> IngresarRecibo(ReciboDto recibo);
        public Task<ReciboDto> ObtenerRecibo(Guid id);
        public Task<ReciboDto> AgregarLote(Guid id, LoteInspeccionDto lote);
        public Task<List<ReciboDto>> ObtenerRecibos();
        public Task CambiarEstado(EstadoRecibo estado, Guid id);

    }
}
