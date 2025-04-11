using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class InspectorRenombradoRequested : INotification
    {
        public Inspector Inspector { get; private set; }
        public InspectorRenombradoRequested(Inspector inspector)
        {
            Inspector = inspector;
        }
    }
}