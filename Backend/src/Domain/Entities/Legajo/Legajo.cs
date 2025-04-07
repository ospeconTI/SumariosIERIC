using System;
using System.Collections.Generic;
using System.Linq;
using OSPeConTI.SumariosIERIC.Domain.SeedWork;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
using OSPeConTI.SumariosIERIC.Domain.Events;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using System.Diagnostics;


namespace OSPeConTI.SumariosIERIC.Domain.Entities
{
    public class Legajo : Entity, IAggregateRoot
    {

        public int IdentificadorIMR { get; private set; }
        public Cuit CUIT { get; private set; }
        public DateTime FechaIngreso { get; private set; }
        public DateTime FechaAsignacion { get; private set; }
        public List<Acta> Actas { get; private set; }

        public Inspector Inspector { get; private set; }

        public Estado Estado { get; private set; }

        private Legajo() { }
        public Legajo(Cuit cuit, DateTime fechaIngreso)
        {
            if (fechaIngreso == null) throw new SumariosDomainException("La Fecha de ingreso no puede ser vacia");

            CUIT = cuit;
            FechaIngreso = fechaIngreso;
            //this.AddDomainEvent(new EmpresaNuevaRequested(this));
        }

        public Guid AgregarActa(Acta acta)
        {
            Actas.Add(acta);
            return acta.Id;
        }
        public void EsAntiEconomico()
        {
            this.Estado = Estado.AntiEconomico;
        }
        public void DarPorFinalizado()
        {
            if (Actas.Count == 0) throw new SumariosDomainException("Debe tener al menos un acta");
            this.Estado = Estado.Finalizado;
        }
    }


}