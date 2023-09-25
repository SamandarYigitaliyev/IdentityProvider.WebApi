using IdentityProvider.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.DataAccess.Interfaces
{
    public interface IGenericRepository<TEntity> : IRepository<TEntity>
            where TEntity : BaseEntitiy
    {
        public IQueryable<TEntity> GetAll();
        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression);
        public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression);
        public Task<TEntity?> LastOrDefaultAsync(Expression<Func<TEntity, bool>> expression);

    }
}
