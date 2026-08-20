using dominio.dtos;
using dominio.enums;
using dominio.interfaces.repositorios;
using dominio.modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class Recibo
    {
        private readonly IReciboRepositorio _reciboRepositorio;
        private Guid _id;
        public EstadoRecibo Estado { get; set; }
        public Guid Id { get { return _id; } }

        public LoteInspeccion? Lote { get; set; }

        public MateriaPrima Suministros { get; set; }

        public Recibo(MateriaPrima suministros, IReciboRepositorio reciboRepositorio)
        {
            _id = Guid.NewGuid();
            Suministros = suministros;
            _reciboRepositorio = reciboRepositorio;
        }
        

        public void AgregarLote(LoteInspeccionDto lote)
        {
            if (Lote is not null) throw new InvalidOperationException("Ya se ha agregado un lote a este recibo.");
            Lote = new LoteInspeccion();
        }


        public void AprobarLote()
        {
            if (Lote is null) throw new InvalidOperationException("No se puede aprobar un lote que no existe.");
            Lote.CambiarEstado(EstadoLote.Aprobado);
            Estado = EstadoRecibo.AprobadoCalidad;
        }

        public void RechazarLote()
        {
            if (Lote is null) throw new InvalidOperationException("No se puede rechazar un lote que no existe.");
            Lote.CambiarEstado(EstadoLote.Rechazado);
            Estado = EstadoRecibo.RechazadoCalidad;
        }
    }
}
