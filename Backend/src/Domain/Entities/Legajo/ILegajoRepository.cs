using OSPeConTI.SumariosIERIC.Domain.SeedWork;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
using OSPeConTI.SumariosIERIC.Domain.Enums;

namespace OSPeConTI.SumariosIERIC.Domain.Entities
{
    public interface ILegajoRepository : IRepository<Legajo>
    {
        Guid Agregar(Legajo Legajo);
        Task<Legajo> GetById(Guid id);
        Task<Legajo> GetByCuit(Cuit cuil);
        bool ActivarLegajo(Legajo Legajo);
        Task<bool> ExistAny(Cuit cuit);
        bool DarPorFinalizadoPorInspector(Inspector inspector);


    }
}