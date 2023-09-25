using IdentityProvider.DataAccess.DbContexts;
using IdentityProvider.DataAccess.Interfaces;
using IdentityProvider.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Linq.Expressions;

namespace IdentityProvider.DataAccess.Repositories
{
    public class GenericRepository<TEntity> : Repository<TEntity>,
        IGenericRepository<TEntity>
        where TEntity : BaseEntitiy
    {
        public GenericRepository(AppDbContext appDb) : base(appDb)
        {
        }


        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
            => await _dbSet.FirstOrDefaultAsync(expression);
        public IQueryable<TEntity> GetAll()
            => _dbSet;
        public Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression)
            => _dbSet.LastOrDefaultAsync(expression);
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
            => _dbSet.Where(expression);
    }
}
