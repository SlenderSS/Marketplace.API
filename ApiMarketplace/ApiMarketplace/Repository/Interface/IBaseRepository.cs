namespace ApiMarketplace.Repository.Interface
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();    
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(Guid id);
    }
}
