namespace ApiMarketplace.Repository.Interface
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(long id);
        Task<TEntity> GetByNameAsync(string name);
        Task<IEnumerable<TEntity>> GetAllAsync();    
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(long id);
        Task<bool> EntityExists(long id);
    }
}
