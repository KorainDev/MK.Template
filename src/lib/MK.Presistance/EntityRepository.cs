using MK.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace MK.Presistance
{
    /// <summary>
    /// represent implementation for data repository
    /// </summary>
    public partial class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        public IQueryable Table => throw new NotImplementedException();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}