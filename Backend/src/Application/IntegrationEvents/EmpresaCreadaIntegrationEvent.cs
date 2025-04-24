using System;
using System.Text.Json.Serialization;
using OSPeConTI.SumariosIERIC.BuildingBlocks.EventBus.Events;

namespace OSPeConTI.SumariosIERIC.Application.IntegrationEvents
{
    public record EmpresaCreadaIntegrationEvent : IntegrationEvent
    {
        [JsonInclude]
        public Guid EmpresaId { get; set; }

        [JsonConstructor]
        public EmpresaCreadaIntegrationEvent(Guid empresaId)
        {
            EmpresaId = empresaId;

        }
    }
}