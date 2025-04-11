using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class InspectorCreadoRequested : INotification
    {
        public Inspector Inspector { get; private set; }
        public InspectorCreadoRequested(Inspector inspector)
        {
            Inspector = inspector;
        }
    }
}
