
using dominio.enums;
using dominio.interfaces.repositorios;
using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class Recibo
    {
        public Guid Id { get; set; }
        public EstadoRecibo Estado { get; set; }

        public LoteInspeccion? Lote { get; set; }

        public MateriaPrima Suministros { get; set; }

        public Recibo(MateriaPrima suministros)
        {
            Id = Guid.NewGuid();
            Suministros = suministros;
        }
        

        public void AgregarLote(LoteInspeccion lote)
        {
            if (Lote is not null) throw new InvalidOperationException("Ya se ha agregado un lote a este recibo.");
            Lote = lote;
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
