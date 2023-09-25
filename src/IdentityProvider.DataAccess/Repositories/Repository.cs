using IdentityProvider.DataAccess.DbContexts;
using IdentityProvider.DataAccess.Interfaces;
using IdentityProvider.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IdentityProvider.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntitiy
    {
        protected DbSet<TEntity> _dbSet;

        public Repository(AppDbContext appDb)
        {
            this._dbSet = appDb.Set<TEntity>();
        }
        public void Add(TEntity entity) => this._dbSet.Add(entity);

        public async Task<long> CountAsync()
            => await _dbSet.CountAsync();
        

        public void Delete(TEntity entity) => this._dbSet?.Remove(entity);

        public async Task<TEntity?> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);
        public void Update(Guid id, TEntity entity)
        {
            entity.Id = id;
            this._dbSet.Update(entity);
        }
    }
}
