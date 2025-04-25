using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using System;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;
using OSPeConTI.SumariosIERIC.Application.IntegrationEvents;

namespace OSPeConTI.SumariosIERIC.Application.Commands
{
    // Regular CommandHandler
    public class AddEmpresaCommandHandler : IRequestHandler<AddEmpresaCommand, Guid>
    {
        private readonly IEmpresaRepository _empresasRepository;

        //private readonly ISumariosIntegrationEventService _sumariosIntegrationEventService;

        //public AddEmpresaCommandHandler(IEmpresaRepository EmpresaRepository, ISumariosIntegrationEventService sumariosIntegrationEventService)
        public AddEmpresaCommandHandler(IEmpresaRepository EmpresaRepository)
        {
            _empresasRepository = EmpresaRepository;
            //_sumariosIntegrationEventService = sumariosIntegrationEventService;
        }

        public async Task<Guid> Handle(AddEmpresaCommand command, CancellationToken cancellationToken)
        {
            Empresa empresaNueva = new Empresa((Cuit)command.CUIT, command.RazonSocial, command.EsCooperativa);
            _empresasRepository.Add(empresaNueva);
            await _empresasRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            /* EmpresaCreadaIntegrationEvent evento = new EmpresaCreadaIntegrationEvent(empresaNueva.Id);

            Guid transactionId = Guid.NewGuid();

            await _sumariosIntegrationEventService.AddAndSaveEventAsync(evento, transactionId);

            await _sumariosIntegrationEventService.PublishEventsThroughEventBusAsync(transactionId); */

            return empresaNueva.Id;
        }
    }
}