using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class InspectorRecodificadoRequested : INotification
    {
        public Inspector Inspector { get; private set; }
        public InspectorRecodificadoRequested(Inspector inspector)
        {
            Inspector = inspector;
        }
    }
}
