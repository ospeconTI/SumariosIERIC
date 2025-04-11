using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class ControlarEstadoAlInactivarInspector : INotificationHandler<InspectorInactivadoRequested>
    {
        private ILegajoRepository LegajoRepository;
        public ControlarEstadoAlInactivarInspector(ILegajoRepository legajoRepository)
        {
            LegajoRepository = legajoRepository;
        }

        public async Task Handle(InspectorInactivadoRequested notification, CancellationToken cancellationToken)
        {
            LegajoRepository.DarPorFinalizadoPorInspector(notification.Inspector);
        }
    }
}