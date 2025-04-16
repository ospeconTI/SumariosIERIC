using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using System.Collections.Generic;
using System;
using System.Runtime.Serialization;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;

namespace OSPeConTI.SumariosIERIC.Application.Commands
{
    [DataContract]
    public class AddInspectorCommand : IRequest<Guid>
    {
        [DataMember]
        public string Apellido { get; set; }

        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string CodigoIERIC { get; set; }

        public AddInspectorCommand() { }
        public AddInspectorCommand(string apellido, string nombre, string codigoIERIC)

        {
            Apellido = apellido;
            Nombre = nombre;
            CodigoIERIC = codigoIERIC;
        }
    }
}