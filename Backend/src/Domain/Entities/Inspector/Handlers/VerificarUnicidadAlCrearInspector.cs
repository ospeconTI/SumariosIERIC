using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class VerificarUnicidadAlCrearInspector : INotificationHandler<InspectorCreadoRequested>
    {
        private IInspectorRepository InspectorRepository;
        public VerificarUnicidadAlCrearInspector(IInspectorRepository inspectorRepository)
        {
            InspectorRepository = inspectorRepository;
        }

        public async Task Handle(InspectorCreadoRequested notification, CancellationToken cancellationToken)
        {
            if (await InspectorRepository.EsUnico(notification.Inspector)) throw new SumariosDomainException("El inspector ya existe en nuestros registros");
        }
    }
}