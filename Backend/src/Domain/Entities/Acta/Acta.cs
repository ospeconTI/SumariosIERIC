using OSPeConTI.SumariosIERIC.Domain.SeedWork;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
using OSPeConTI.SumariosIERIC.Domain.Events;
using System.Security.Cryptography.X509Certificates;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Location;
using System;


namespace OSPeConTI.SumariosIERIC.Domain.Entities
{
    public class Acta : Entity, IAggregateRoot
    {

        public Direccion Domicilio { get; set; }
        public DateTime FechaControl { get; set; }
        public int CantidadObreros { get; set; }
        public Acta()
        {

        }
        public Acta(Direccion domicilio)
        {
            Domicilio = domicilio;
        }
    }
}