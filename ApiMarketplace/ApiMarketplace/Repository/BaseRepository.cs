using ApiMarketplace.Database;
using ApiMarketplace.Helpers;
using ApiMarketplace.Models;
using ApiMarketplace.Repository.Interface;
using CSharpFunctionalExtensions;
using Microsoft.EntityFrameworkCore;


namespace ApiMarketplace.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity
    {
        protected readonly MarketplaceContext _context;

        public BaseRepository(MarketplaceContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetByIdAsync(long id)
        {
            return await _context
                .Set<TEntity>()
                .FirstOrDefaultAsync(entity => entity.Id == id);
        }

        public Task<TEntity> GetByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(FilterSortParameters filter)
        {
            return await _context.Set<TEntity>().ToListAsync();

        }

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

        public virtual async Task<bool> DeleteAsync(long id)
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

        public Task<bool> EntityExists(long id)
        {
            throw new NotImplementedException();
        }

        public virtual IQueryable<TEntity> BuildQuery()
        {
            return _context.Set<TEntity>().AsQueryable();
        }
    }
}
