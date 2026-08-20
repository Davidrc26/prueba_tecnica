using dominio.dtos;
using dominio.enums;
using dominio.interfaces.repositorios;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.persistencia.repositorios
{
    public class ReciboRepositorio : IReciboRepositorio
    {

        private readonly AppDbContext _context;

        public ReciboRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public Task<ReciboDto> AgregarLote(Guid id, LoteInspeccionDto lote)
        {
            throw new NotImplementedException();
        }

        public Task CambiarEstado(EstadoRecibo estado, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ReciboDto> IngresarRecibo(ReciboDto recibo)
        {
            throw new NotImplementedException();
        }

        public async Task<ReciboDto> ObtenerRecibo(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ReciboDto>> ObtenerRecibos()
        {
            throw new NotImplementedException();
        }
    }
}
