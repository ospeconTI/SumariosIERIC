using Microsoft.EntityFrameworkCore;
using OSPeConTI.SumariosIERIC.Domain.Entities;
using OSPeConTI.SumariosIERIC.Domain.SeedWork;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace OSPeConTI.SumariosIERIC.Infrastructure.Repositories
{
    public class InspectorRepository : IInspectorRepository

    {
        private readonly SumariosContext _context;

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _context;
            }
        }

        public InspectorRepository(SumariosContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Guid Crear(Inspector inspector)
        {
            _context.Inspectores.Add(inspector);
            return inspector.Id;
        }

        public async Task<Inspector> ObtenerPorId(Guid id)
        {
            return await _context.Inspectores.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<List<Inspector>> ObtenerTodos()
        {
            return await _context.Inspectores.ToListAsync();
        }

        public Inspector Modificar(Inspector inspector)
        {
            _context.Inspectores.Update(inspector);
            return inspector;
        }

        public async Task<bool> EsUnico(Inspector inspector)
        {
            return !_context.Inspectores.Any(i => i.Id != inspector.Id && (i.Apellido == inspector.Apellido && i.Nombre == inspector.Nombre || i.CodigoIERIC == inspector.CodigoIERIC));
        }

        public async Task<bool> EsUnicoApellidoYNombre(Inspector inspector)
        {
            return !_context.Inspectores.Any(i => i.Id != inspector.Id && i.Apellido == inspector.Apellido && i.Nombre == inspector.Nombre);
        }

        public async Task<bool> EsUnicoCodigoIERIC(Inspector inspector)
        {
            return !_context.Inspectores.Any(i => i.Id != inspector.Id && i.CodigoIERIC == inspector.CodigoIERIC);
        }
    }
}