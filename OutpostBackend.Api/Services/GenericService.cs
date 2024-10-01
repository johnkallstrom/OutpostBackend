using Microsoft.EntityFrameworkCore;
using OutpostBackend.Core.Interfaces;
using OutpostBackend.Data;

namespace OutpostBackend.Api.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _entity;
        private readonly OutpostDbContext _context;

        public GenericService(OutpostDbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetListAsync() => await _entity.ToListAsync();
    }
}
