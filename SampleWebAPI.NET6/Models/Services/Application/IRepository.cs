using SampleWebAPI.NET6.Models.Entities;

namespace SampleWebAPI.NET6.Models.Services.Application
{
    public interface IRepository<TEntity, TPrimaryKey> where TEntity : Entity<TPrimaryKey>
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TPrimaryKey id);
        Task InsertAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TPrimaryKey id);
    }
}