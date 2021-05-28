using MK.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace MK.Presistance
{
    /// <summary>
    /// represent data access using repository pattern
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Insert entity to data
        /// </summary>
        /// <param name="entity">entity to insert</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the  entity entry after insert
        /// </returns>
        Task<TEntity> InsertAsync(TEntity entity);

        /// <summary>
        /// Insert entity to data
        /// </summary>
        /// <param name="entity">entity to insert</param>
        /// <returns>inserted entity</returns>
        TEntity Insert(TEntity entity);

        /// <summary>
        /// Delete entity from data
        /// </summary>
        /// <param name="id">entity identifier</param>
        /// <returns> A task that represents the asynchronous operation</returns>
        Task DeleteAsync(int id);

        /// <summary>
        /// Delete entity from data
        /// </summary>
        /// <param name="id">entity identifier</param>
        /// <returns></returns>
        void Delete(int id);

        /// <summary>
        /// Delete entity from data
        /// </summary>
        /// <param name="entity">entity to delete</param>
        /// <returns> A task that represents the asynchronous operation</returns>
        Task DeleteAsync(TEntity entity);

        /// <summary>
        /// Delete entity from data
        /// </summary>
        /// <param name="entity">entity to delete</param>
        /// <returns></returns>
        void Delete(TEntity entity);

        /// <summary>
        /// update entity in data
        /// </summary>
        /// <param name="entity">entity to update</param>
        /// <returns>
        /// A task that represents the asynchronous operation
        /// The task result contains the  entity entry after update</returns>
        Task<TEntity> UpdateAsync(TEntity entity);

        /// <summary>
        /// update entity in data
        /// </summary>
        /// <param name="entity">entity to update</param>
        /// <returns>
        /// entity entry after update</returns>
        Task<TEntity> Update(TEntity entity);

        /// <summary>
        ///  Gets a table
        /// </summary>
        IQueryable Table { get; }
    }
}