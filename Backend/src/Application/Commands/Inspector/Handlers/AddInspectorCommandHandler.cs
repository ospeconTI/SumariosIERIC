using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using System;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;

namespace OSPeConTI.SumariosIERIC.Application.Commands
{
    // Regular CommandHandler
    public class AddInspectorCommandHandler : IRequestHandler<AddInspectorCommand, Guid>
    {
        private readonly IInspectorRepository _InspectorsRepository;

        public AddInspectorCommandHandler(IInspectorRepository InspectorRepository)
        {
            _InspectorsRepository = InspectorRepository;
        }

        public async Task<Guid> Handle(AddInspectorCommand command, CancellationToken cancellationToken)
        {
            Inspector nuevo = new Inspector(command.Apellido, command.Nombre, command.CodigoIERIC);
            _InspectorsRepository.Crear(nuevo);
            await _InspectorsRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
            return nuevo.Id;
        }
    }
}