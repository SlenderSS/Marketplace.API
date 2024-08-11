using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiMarketplace.Repository
{
    public  class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly MarketplaceContext _context;

        public BaseRepository(MarketplaceContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetByIdAsync(Guid id) => await BuildQuery().FirstOrDefaultAsync(entity => entity.Id == id);
        public async Task<IEnumerable<TEntity>> GetAllAsync() => await BuildQuery().ToListAsync();

        public virtual async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return false;
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        public virtual IQueryable<TEntity> BuildQuery()
        {
            return _context.Set<TEntity>().AsQueryable();
        }
    }
}
