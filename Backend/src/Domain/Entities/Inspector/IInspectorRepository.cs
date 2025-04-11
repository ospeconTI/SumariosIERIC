using OSPeConTI.SumariosIERIC.Domain.SeedWork;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;

namespace OSPeConTI.SumariosIERIC.Domain.Entities
{
    public interface IInspectorRepository : IRepository<Inspector>
    {
        Guid Crear(Inspector inspector);
        Task<Inspector> ObtenerPorId(Guid id);
        Task<List<Inspector>> ObtenerTodos();
        Inspector Modificar(Inspector inspector);

        Task<bool> EsUnico(Inspector inspector);
        Task<bool> EsUnicoApellidoYNombre(Inspector inspector);
        Task<bool> EsUnicoCodigoIERIC(Inspector inspector);

    }
}