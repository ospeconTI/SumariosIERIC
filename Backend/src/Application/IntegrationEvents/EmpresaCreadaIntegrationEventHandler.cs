using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OSPeConTI.SumariosIERIC.BuildingBlocks.EventBus.Abstractions;
using OSPeConTI.SumariosIERIC.Domain.Entities;


namespace OSPeConTI.SumariosIERIC.Application.IntegrationEvents
{
    public class EmpresaCreadaIntegrationEventHandler : IIntegrationEventHandler<EmpresaCreadaIntegrationEvent>
    {
        private readonly ILogger<EmpresaCreadaIntegrationEventHandler> _logger;
        private readonly IEmpresaRepository _repository;



        public EmpresaCreadaIntegrationEventHandler(
            ILogger<EmpresaCreadaIntegrationEventHandler> logger,
            IEmpresaRepository repository
)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

        }

        public async Task Handle(EmpresaCreadaIntegrationEvent @event)
        {
            _logger.LogInformation("Se Creo la empresa Id = " + @event.EmpresaId.ToString());

        }
    }


}