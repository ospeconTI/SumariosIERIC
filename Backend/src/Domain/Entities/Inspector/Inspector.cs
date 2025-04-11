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

        public string Apellido { get; private set; }
        public string Nombre { get; private set; }
        public string CodigoIERIC { get; private set; }
        private Inspector() { }
        public Inspector(string apellido, string nombre, string codigoIERIC)
        {
            if (string.IsNullOrEmpty(apellido)) throw new SumariosDomainException("El apellido del isnpector no puede quedar vacio");
            if (string.IsNullOrEmpty(nombre)) throw new SumariosDomainException("El nombre del inspetor no puede quedar vacio");
            if (string.IsNullOrEmpty(codigoIERIC)) throw new SumariosDomainException("El codigo del inspector no puede quedar vacio");

            Apellido = apellido;
            Nombre = nombre;
            CodigoIERIC = codigoIERIC;

            AddDomainEvent(new InspectorCreadoRequested(this));
        }

        public void Renombrar(string apellido, string nombre)
        {
            if (string.IsNullOrEmpty(apellido)) throw new SumariosDomainException("El apellido del isnpector no puede quedar vacio");
            if (string.IsNullOrEmpty(nombre)) throw new SumariosDomainException("El nombre del inspetor no puede quedar vacio");

            Apellido = apellido;
            Nombre = nombre;

            AddDomainEvent(new InspectorRenombradoRequested(this));
        }

        public void Recodificar(string codigoIERIC)
        {
            if (string.IsNullOrEmpty(codigoIERIC)) throw new SumariosDomainException("El codigo del inspector no puede quedar vacio");
            CodigoIERIC = codigoIERIC;

            AddDomainEvent(new InspectorRecodificadoRequested(this));
        }

        public void Inactivar()
        {
            Activo = false;

            AddDomainEvent(new InspectorActivadoRequested(this));
        }
        public void Activar()
        {
            Activo = true;

            AddDomainEvent(new InspectorActivadoRequested(this));
        }


    }
}