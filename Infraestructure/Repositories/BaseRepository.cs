using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using ApplicationCore.Models;
using ApplicationCore.Models.Response;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
         where TEntity : EntityBase, IEntityBase, new()
    {
        protected readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context) => _context = context;

        #region IBaseRepository Implementation
        public async Task<TEntity> DeleteAsync(TEntity entity, bool saveChanges = true)
        {
            _context.Remove(entity);
            if (saveChanges)
                await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> DeleteRangeAsync(List<TEntity> entity, bool saveChanges = true)
        {
            _context.RemoveRange(entity);
            if (saveChanges)
                return await _context.SaveChangesAsync();

            return 0;
        }

        public async Task<TEntity> FindByIdAsync(params object[] ids)
        {
            return await _context.FindAsync<TEntity>(ids);
        }

        public async Task<List<TEntity>> GetItemsAsync(Expression<Func<TEntity, bool>> where = null, string[] includes = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> callback = null, bool isReadOnly = true)
        {
            return await GetItemsAsync(q => q, where, includes, callback, isReadOnly);
        }

        public async Task<List<TResponse>> GetItemsAsync<TResponse>(Expression<Func<TEntity, TResponse>> select, Expression<Func<TEntity, bool>> where = null,
            string[] includes = null, Func<IQueryable<TEntity>, IQueryable<TEntity>> callback = null, bool isReadOnly = true)
        {
            IQueryable<TEntity> results = _context.Set<TEntity>();

            if (includes != null)
            {
                foreach (var item in includes)
                    results = results.Include(item);
            }

            if (callback != null)
                results = callback.Invoke(results);
            if (where != null)
                results = results.Where(where);
            if (isReadOnly)
                results = results.AsNoTracking();

            return await results.Select(select).ToListAsync();
        }

        public async Task<TEntity> InsertAsync(TEntity entity, ClaimsPrincipal user = null, bool saveChanges = true)
        {
            _context.Add(entity);

            if (saveChanges)
                await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<int> InsertRangeAsync(List<TEntity> entities, ClaimsPrincipal user = null, bool saveChanges = true)
        {
            _context.AddRange(entities);
            if (saveChanges)
                await _context.SaveChangesAsync();

            return 1;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, ClaimsPrincipal user = null, bool saveChanges = true)
        {
            _context.Update(entity);
            if (saveChanges)
                await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> UpdateRangeAsync(List<TEntity> entity, ClaimsPrincipal user = null, bool saveChanges = true)
        {
            _context.UpdateRange(entity);
            if (saveChanges)
                await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, ClaimsPrincipal user = null, bool saveChanges = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var dbEntry = _context.Entry(entity);

            foreach (var includeProperty in includeProperties)
                dbEntry.Property(includeProperty).IsModified = true;

            if (saveChanges)
                await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateReferencesAsync<TProperty>(TEntity entity, bool saveChanges = true, params Expression<Func<TEntity, IEnumerable<TProperty>>>[] includeReferences)
            where TProperty : class
        {
            var dbEntry = _context.Entry(entity);

            foreach (var includeProperty in includeReferences)
                dbEntry.Collection(includeProperty).IsModified = true;

            if (saveChanges)
                await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> where = null, string[] includes = null)
        {
            IQueryable<TEntity> results = _context.Set<TEntity>();

            if (includes != null)
            {
                foreach (var item in includes)
                    results = results.Include(item);
            }
            return await results.AnyAsync(where, default(CancellationToken));
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> where = null, string[] includes = null)
        {
            IQueryable<TEntity> results = _context.Set<TEntity>();

            if (includes != null)
            {
                foreach (var item in includes)
                    results = results.Include(item);
            }

            if (where != null)
                return await results.CountAsync(where);
            else
                return await results.CountAsync();
        }

        public async Task<decimal> MaxAsync(Expression<Func<TEntity, decimal>> selector, Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (where != null)
                query = query.Where(where);

            try
            {
                return await query.MaxAsync(selector);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<int> MaxAsync(Expression<Func<TEntity, int>> selector, Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (where != null)
                query = query.Where(where);

            try
            {
                return await query.MaxAsync(selector);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<decimal> SumAsync(Expression<Func<TEntity, decimal>> selector, Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (where != null)
                query = query.Where(where);

            try
            {
                return await query.SumAsync(selector);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> where = null, string[] includes = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> callback = null, bool isReadOnly = true)
        {
            return await GetAsync(q => q, where, includes, callback, isReadOnly);
        }

        public async Task<TResponse> GetAsync<TResponse>(Expression<Func<TEntity, TResponse>> select,
            Expression<Func<TEntity, bool>> where = null, string[] includes = null,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> callback = null, bool isReadOnly = true)
        {
            IQueryable<TEntity> results = _context.Set<TEntity>();

            if (includes != null)
            {
                foreach (var item in includes)
                    results = results.Include(item);
            }

            if (callback != null)
                results = callback.Invoke(results);
            if (where != null)
                results = results.Where(where);
            if (isReadOnly)
                results = results.AsNoTracking();

            return await results.Select(select).FirstOrDefaultAsync();
        }

        public async Task<PaginationResponse<TResponse>> GetPagingResultAsync<TResponse>(int page, int length,
            Expression<Func<TEntity, TResponse>> select,
            Func<IQueryable<TEntity>, IQueryable<TEntity>> query = null,
            Expression<Func<TEntity, bool>> searchExpression = null,
            List<SortModel<TEntity>> sortModels = null, string[] includes = null)
        {
            IQueryable<TEntity> results = _context.Set<TEntity>();
            var response = new PaginationResponse<TResponse>();
            page = page == 0 ? 1 : page;
            var start = (page - 1) * length;

            if (includes != null)
            {
                foreach (var item in includes)
                    results = results.Include(item);
            }

            if (query != null)
                results = query.Invoke(results);

            //This gives us number of all records found
            var total = await results.CountAsync();

            if (searchExpression != null)
            {
                results = results.Where(searchExpression);
                response.TotalFiltered = await results.CountAsync();
            }

            if (sortModels != null)
            {
                foreach (var item in sortModels)
                {
                    if (item.SortExpression != null && item.SortDirection != SortDirection.None)
                    {
                        results = item.SortDirection == SortDirection.Desc
                            ? results.OrderByDescending(item.SortExpression)
                            : results.OrderBy(item.SortExpression);
                    }
                }
            }

            if (length != -1)
                results = results.Skip(start).Take(length);
            //This gives us number of records filtered
            response.TotalFiltered = await results.CountAsync();
            response.Total = total;
            response.Result = await results.AsNoTracking().Select(select).ToListAsync();
            response.HasMore = response.TotalFiltered > page * length;
            response.QuantityPages = Convert.ToInt32(Math.Ceiling((decimal)total / length));
            response.QuantityPagesFiltered = Convert.ToInt32(Math.Ceiling((decimal)response.TotalFiltered / length));

            return response;
        }

        public void Detach(TEntity entity)
            => _context.Entry(entity).State = EntityState.Detached;

        public async Task SaveChangesAsync()
            => await _context.SaveChangesAsync();

        #endregion

    }
}
