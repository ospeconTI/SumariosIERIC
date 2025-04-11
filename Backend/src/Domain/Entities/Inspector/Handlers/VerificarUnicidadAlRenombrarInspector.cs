using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class VerificarUnicidadAlRenombrarInspector : INotificationHandler<InspectorRenombradoRequested>
    {
        private IInspectorRepository InspectorRepository;
        public VerificarUnicidadAlRenombrarInspector(IInspectorRepository inspectorRepository)
        {
            InspectorRepository = inspectorRepository;
        }

        public async Task Handle(InspectorRenombradoRequested notification, CancellationToken cancellationToken)
        {
            if (await InspectorRepository.EsUnicoApellidoYNombre(notification.Inspector)) throw new SumariosDomainException(string.Format("El inspector ${0},${1} ya existe en nuestros registros", new[] { notification.Inspector.Apellido, notification.Inspector.Nombre }));
        }
    }
}