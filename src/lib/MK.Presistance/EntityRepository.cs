using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MK.Domain;

namespace MK.Presistance
{
    /// <summary>
    /// represent implementation for data repository
    /// </summary>
    public partial class EntityRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        #region Fields

        private readonly MKDbContext _dbContext;

        #endregion Fields

        #region ctor

        public EntityRepository(MKDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion ctor

        #region Properties

        public IQueryable Table => _dbContext.Set<TEntity>().AsQueryable();

        #endregion Properties

        public void Delete(int id)
        {
            var context = _dbContext.Set<TEntity>();
            var obj = context.Where(x => x.ID == id).FirstOrDefault();
            if (obj != null)
            {
                context.Remove(obj);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            var context = _dbContext.Set<TEntity>();
            context.Remove(entity);
            _dbContext.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var context = _dbContext.Set<TEntity>();
            var obj = await context.Where(x => x.ID == id).FirstOrDefaultAsync();
            if (obj != null)
            {
                context.Remove(obj);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            var context = _dbContext.Set<TEntity>();
            context.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public TEntity Insert(TEntity entity)
        {
            var context = _dbContext.Set<TEntity>();
            context.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            var context = _dbContext.Set<TEntity>();
            await context.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}