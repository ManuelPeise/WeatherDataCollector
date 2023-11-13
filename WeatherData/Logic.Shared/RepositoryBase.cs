using Logic.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Database.Entities;
using System.Linq.Expressions;

namespace Logic.Shared
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntityBase
    {
        private readonly Data.Database.AppContext _appContext;

        public List<TEntity> Entities { get => _appContext.Set<TEntity>().ToList(); }

        public RepositoryBase(Data.Database.AppContext appContext)
        {
            _appContext = appContext;
        }


        public async Task<TEntity?> Add(TEntity objModel)
        {
            var entity = await _appContext.Set<TEntity>().AddAsync(objModel);
           
            await _appContext.SaveChangesAsync();

            return entity.Entity;
        }
        public async Task AddRange(IEnumerable<TEntity> objModel)
        {
            await _appContext.Set<TEntity>().AddRangeAsync(objModel);

            await _appContext.SaveChangesAsync();
        }
        public async Task<TEntity?> GetById(int id)
        {
            return await _appContext.Set<TEntity>().FindAsync(id);
        }
        public async Task<TEntity?> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return await _appContext.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }
        public async Task<IEnumerable<TEntity>> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            return await _appContext.Set<TEntity>().Where<TEntity>(predicate).ToListAsync();
        }
        public async Task<int> GetEntityCount()
        {
            return await Task.FromResult(_appContext.Set<TEntity>().Count());
        }
        public async Task Update(TEntity objModel)
        {
            _appContext.Entry(objModel).State = EntityState.Modified;
           
            await _appContext.SaveChangesAsync();
        }
        public async Task Remove(TEntity objModel)
        {
            _appContext.Set<TEntity>().Remove(objModel);

            await _appContext.SaveChangesAsync();
        }

    }
}
