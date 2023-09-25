using IdentityProvider.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityProvider.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntitiy
    {
        public Task<long> CountAsync();
        public void Add(TEntity entity);
        public void Update(Guid id, TEntity entity);
        public void Delete(TEntity entity);
        public Task<TEntity?> GetByIdAsync(Guid id);
    }
}
