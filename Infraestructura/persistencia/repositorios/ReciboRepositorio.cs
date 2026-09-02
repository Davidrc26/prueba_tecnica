using dominio.entidades;
using dominio.enums;
using dominio.interfaces.repositorios;
using Infraestructura.persistencia.modelos;
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

        public Task CambiarEstado(EstadoRecibo estado, Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Recibo> IngresarRecibo(Recibo recibo)
        {
            var materiaPrimaEntity = new MateriaPrimaDb
            {
                Id = recibo.Suministros.Id,
                Nombre = recibo.Suministros.Nombre,
                Cantidad = recibo.Suministros.Cantidad,
                UnidadMedida = recibo.Suministros.UnidadMedida,
                ProveedorId = recibo.Suministros.Proveedor.Id
            };

            var reciboEntity = new ReciboDb
            {
                Id = recibo.Id,
                Estado = recibo.Estado,
                MateriaPrimaId = recibo.Suministros.Id,
                MateriaPrima = materiaPrimaEntity
            };

            await _context.Recibos.AddAsync(reciboEntity);
            await _context.SaveChangesAsync();

            return recibo;
        }

        public async Task<Recibo> ObtenerDetalleRecibo(Guid id)
        {
            var reciboEntity = await _context.Recibos
                .Include(r => r.MateriaPrima)
                .ThenInclude(mp => mp.Proveedor)
                .Include(r => r.LoteInspeccion)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (reciboEntity == null) throw new ArgumentException("Recibo no encontrado");

            var proveedor = new Proveedor(
                reciboEntity.MateriaPrima.ProveedorId,
                reciboEntity.MateriaPrima.Proveedor?.Nombre ?? string.Empty,
                reciboEntity.MateriaPrima.Proveedor?.Nit ?? string.Empty
            );

            var materiaPrima = new MateriaPrima(
                id: reciboEntity.MateriaPrima.Id,
                nombre: reciboEntity.MateriaPrima.Nombre,
                proveedor: proveedor,
                cantidad: reciboEntity.MateriaPrima.Cantidad,
                unidadMedida: reciboEntity.MateriaPrima.UnidadMedida
            );

            var recibo = new Recibo(materiaPrima)
            {
                Id = reciboEntity.Id,
                Estado = reciboEntity.Estado,
                Lote = reciboEntity.LoteInspeccion != null ? new LoteInspeccion
                {
                    Id = reciboEntity.LoteInspeccion.Id,
                } : null
            };

            return recibo;
        }

        public Task<List<Recibo>> ObtenerRecibos()
        {
            throw new NotImplementedException();
        }

  

       
    }
}
