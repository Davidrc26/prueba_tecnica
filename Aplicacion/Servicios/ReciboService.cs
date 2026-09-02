using Aplicacion.CasosUso;
using Aplicacion.dtos;
using Aplicacion.Mappers.Interfaces;
using dominio.entidades;
using dominio.interfaces.repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Servicios
{
    public class ReciboService : ICrearReciboMateriaPrima
    {
        private readonly IReciboRepositorio _reciboRepositorio;
        private readonly IMapper<Recibo, ReciboDto> _reciboMapper;

        public ReciboService(IReciboRepositorio reciboRepositorio, IMapper<Recibo, ReciboDto> reciboMapper)
        {
            _reciboRepositorio = reciboRepositorio;
            _reciboMapper = reciboMapper;
        }

        public async Task<ReciboDto> CrearReciboMateriaPrima(ReciboDto request)
        {
            var entidad = _reciboMapper.MapReverse(request);
            var created = await _reciboRepositorio.IngresarRecibo(entidad); 
            var dto = _reciboMapper.Map(created);
            return dto;
        }
    }
}
