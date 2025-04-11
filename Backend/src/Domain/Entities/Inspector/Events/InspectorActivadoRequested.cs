using MediatR;
using OSPeConTI.SumariosIERIC.Domain.Entities;
namespace OSPeConTI.SumariosIERIC.Domain.Events
{
    public class InspectorActivadoRequested : INotification
    {
        public Inspector Inspector { get; private set; }
        public InspectorActivadoRequested(Inspector inspector)
        {
            Inspector = inspector;
        }
    }
}