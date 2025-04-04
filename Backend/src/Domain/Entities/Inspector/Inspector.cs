using OSPeConTI.SumariosIERIC.Domain.SeedWork;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
using OSPeConTI.SumariosIERIC.Domain.Events;
using System.Security.Cryptography.X509Certificates;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Location;
using System;


namespace OSPeConTI.SumariosIERIC.Domain.Entities
{
    public class Inspector : Entity, IAggregateRoot
    {

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CodigoIERIC { get; set; }
        private Inspector() { }
        public Inspector(string apellido)
        {
            Apellido = apellido;
        }
    }
}