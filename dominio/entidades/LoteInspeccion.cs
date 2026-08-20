using dominio.dtos;
using dominio.entidades;
using dominio.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace dominio.entidades
{
    public class LoteInspeccion
    {
        private Guid _id;
        public Guid Id { get { return _id; } }

        public EstadoLote Estado { get; set; }

        public List<Muestreo> Muestreos { get; set; }
        public LoteInspeccion() 
        { 
            _id = Guid.NewGuid();
            Estado = EstadoLote.Pendiente;
            Muestreos = new List<Muestreo>();
        }


        public void AgregarMuestreo(Muestreo muestreo)
        {
            if(Estado != EstadoLote.Pendiente)
            {
                throw new InvalidOperationException("No se puede agregar un muestreo a un lote que no está pendiente.");
            }
            Muestreos.Add(muestreo);
        }

        public void CambiarEstado(EstadoLote nuevoEstado)
        {
            if (nuevoEstado == EstadoLote.Pendiente)
            {
                throw new InvalidOperationException("No se puede cambiar el estado a Pendiente.");
            }
            Estado = nuevoEstado;
        }



    }
}
