using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces.IRepositories
{
    //public interface IBaseRepository<TEntity> where TEntity : IEntityBase
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> InsertAsync(TEntity entity, ClaimsPrincipal user = null, bool saveChanges = true);
        Task<int> InsertRangeAsync(List<TEntity> entities, ClaimsPrincipal user = null, bool saveChanges = true);
        Task<TEntity> DeleteAsync(TEntity entity, bool saveChanges = true);
        Task<int> DeleteRangeAsync(List<TEntity> entity, bool saveChanges = true);

        Task<TEntity> UpdateAsync(TEntity entity, ClaimsPrincipal user = null, bool saveChanges = true);
        Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entity, ClaimsPrincipal user = null, bool saveChanges = true);
        Task<TEntity> UpdateAsync(TEntity entity, ClaimsPrincipal user = null, bool saveChanges = true, params Expression<Func<TEntity, object>>[] includeProperties);
        Task<TEntity> UpdateReferencesAsync<TProperty>(TEntity entity, bool saveChanges = true, params Expression<Func<TEntity, IEnumerable<TProperty>>>[] includeReferences)
            where TProperty : class;
        /// <summary>
        /// Get items of TEntity optionally filtered by where with includes
        /// </summary>
        /// <param name="where">Filter to apply in the query</param>
        /// <param name="includes">List of includes for join entities</param>
        /// <param name="callback">Callback to execute before execute SQL Query</param>
        /// <param name="isReadOnly">Specifies whether the query is read-only</param>
        /// <returns></returns>
        Task<List<TEntity>> GetItemsAsync(Expression<Func<TEntity, bool>> where = null, string[] includes = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> callback = null, bool isReadOnly = true);
        /// <summary>
        /// Get items of TEntity optionally filtered by where with includes
        /// </summary>
        /// <param name="select">Selector to apply in the query</param>
        /// <param name="where">Filter to apply in the query</param>
        /// <param name="includes">List of includes for join entities</param>
        /// <param name="callback">Callback to execute before execute SQL Query</param>
        /// <param name="isReadOnly">Specifies whether the query is read-only</param>
        /// <returns></returns>
        Task<List<TResponse>> GetItemsAsync<TResponse>(Expression<Func<TEntity, TResponse>> select, Expression<Func<TEntity, bool>> where = null,
            string[] includes = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> callback = null, bool isReadOnly = true);
        /// <summary>
        /// Retrieve the instance of TEntity filtered by primary keys
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<TEntity> FindByIdAsync(params object[] ids);
        /// <summary>
        /// Retrieve the instance of Entity optionally filtered by where with includes
        /// </summary>
        /// <param name="where">Filter to apply in the query</param>
        /// <param name="includes">List of includes for join entities</param>
        /// <param name="callback">Callback to execute before execute SQL Query</param>
        /// <param name="isReadOnly">Specifies whether the query is read-only</param>
        /// <returns></returns>
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where = null, string[] includes = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> callback = null, bool isReadOnly = true);
        /// <summary>
        /// Retrieve the instance of Entity optionally filtered by where with includes
        /// </summary>
        /// <param name="select">Selector to apply in the query</param>
        /// <param name="where">Filter to apply in the query</param>
        /// <param name="includes">List of includes for join entities</param>
        /// <param name="callback">Callback to execute before execute SQL Query</param>
        /// <param name="isReadOnly">Specifies whether the query is read-only</param>
        /// <returns></returns>
        Task<TResponse> GetAsync<TResponse>(Expression<Func<TEntity, TResponse>> select, Expression<Func<TEntity, bool>> where = null, string[] includes = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> callback = null, bool isReadOnly = true);
        /// <summary>
        /// Count the items of an Entity optionally filtered by where
        /// </summary>
        /// <returns></returns>
        Task<int> CountAsync(Expression<Func<TEntity, bool>> where = null, string[] includes = null);
        Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> where = null, string[] includes = null);
        Task<decimal> MaxAsync(Expression<Func<TEntity, decimal>> selector, Expression<Func<TEntity, bool>> where = null);
        Task<int> MaxAsync(Expression<Func<TEntity, int>> selector, Expression<Func<TEntity, bool>> where = null);
        Task<decimal> SumAsync(Expression<Func<TEntity, decimal>> selector, Expression<Func<TEntity, bool>> where = null);
        Task<PaginationResponse<TResponse>> GetPagingResultAsync<TResponse>(int page, int length, Expression<Func<TEntity, TResponse>> select, Func<IQueryable<TEntity>, IQueryable<TEntity>> query = null,
            Expression<Func<TEntity, bool>> searchExpression = null, List<SortModel<TEntity>> sortModels = null, string[] includes = null);
        void Detach(TEntity entity);
        Task SaveChangesAsync();
    }
}
