using Shared.Database.Entities;
using System.Linq.Expressions;

namespace Logic.Shared.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        List<TEntity> Entities { get; }
        Task<TEntity?> Add(TEntity objModel);
        Task AddRange(IEnumerable<TEntity> objModel);
        Task<TEntity?> GetById(int id);
        Task<TEntity?> Get(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> predicate);
        Task<int> GetEntityCount();
        Task Update(TEntity objModel);
        Task Remove(TEntity objModel);


    }
}
