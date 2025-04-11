using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.Enums;
using OSPeConTI.SumariosIERIC.Domain.Exceptions;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class VerificarUnicidadAlRecodificarInspector : INotificationHandler<InspectorRecodificadoRequested>
    {
        private IInspectorRepository InspectorRepository;
        public VerificarUnicidadAlRecodificarInspector(IInspectorRepository inspectorRepository)
        {
            InspectorRepository = inspectorRepository;
        }

        public async Task Handle(InspectorRecodificadoRequested notification, CancellationToken cancellationToken)
        {
            if (await InspectorRepository.EsUnicoCodigoIERIC(notification.Inspector)) throw new SumariosDomainException(string.Format("El inspector el codigo ${0} ya existe en nuestros registros", notification.Inspector.CodigoIERIC));
        }
    }
}