using Microsoft.EntityFrameworkCore;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.SeedWork;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using OSPeConTI.SumariosIERIC.Domain.ValueObjects.Network;
using OSPeConTI.SumariosIERIC.Domain.Enums;

namespace OSPeConTI.SumariosIERIC.Infrastructure.Repositories
{
    public class LegajoRepository : ILegajoRepository

    {
        private readonly SumariosContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public LegajoRepository(SumariosContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Guid Agregar(Legajo Legajo)
        {
            throw new NotImplementedException();
        }

        public Task<Legajo> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Legajo> GetByCuit(Cuit cuil)
        {
            throw new NotImplementedException();
        }

        public bool ActivarLegajo(Legajo Legajo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistAny(Cuit cuit)
        {
            throw new NotImplementedException();
        }

        public bool DarPorFinalizadoPorInspector(Inspector inspector)
        {
            _context.Legajos
            .Where(l => l.Inspector.Id == inspector.Id)
            .ExecuteUpdate(l => l.SetProperty(p => p.Estado, Estado.Finalizado));
            return true;
        }
    }
}