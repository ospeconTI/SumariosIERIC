using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class InspectorInactivadoRequested : INotification
    {
        public Inspector Inspector { get; private set; }
        public InspectorInactivadoRequested(Inspector inspector)
        {
            Inspector = inspector;
        }
    }
}