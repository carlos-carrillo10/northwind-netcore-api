using BLL.IRepositories;
using DAL.Data;
using Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        internal ApplicationDbContext _context;
        internal DbSet<TEntity> dbSet;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }

        public RequestResponse Delete(TEntity entityToDelete, bool SaveChanges = false)
        {
            try
            {
                dbSet.Remove(entityToDelete);
                return new RequestResponse(true);
            }
            catch (Exception ex)
            {
                return new RequestResponse(ex);
            }
        }

        public RequestResponse Delete(int id, bool SaveChanges = false)
        {
            try
            {
                dbSet.Remove(dbSet.Find(id));
                return new RequestResponse(true);
            }
            catch (Exception ex)
            {
                return new RequestResponse(ex);
            }
        }

        public RequestResponse DeleteRange(ICollection<TEntity> entityToDelete, bool SaveChanges = false)
        {
            try
            {
                dbSet.RemoveRange(entityToDelete);
                return new RequestResponse(true);
            }
            catch (Exception ex)
            {
                return new RequestResponse(ex);
            }
        }

        public RequestResponse<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includes = "")
        {
            try
            {
                var query = dbSet.AsQueryable();

                if (filter != null)
                {
                    query = query.Where(filter);
                }

                if (includes != null)
                {
                    foreach (var value in includes.Split
                    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(value);
                    }
                }

                var records = default(List<TEntity>);

                if (orderBy != null)
                {
                    records = orderBy(query).ToList();
                }
                else
                {
                    records = query.ToList();
                }
                return new RequestResponse<TEntity>(records);
            }
            catch (Exception ex)
            {
                return new RequestResponse<TEntity>(ex);
            }
        }

        public RequestResponse<TEntity> GetByID(int id, string includes = "")
        {
            try
            {
                //var query = dbSet;

                //if (includes != null)
                //{
                //    foreach (var value in includes.Split
                //    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                //    {
                //        query = query.Include<value>();
                //    }
                //}
                return new RequestResponse<TEntity>(dbSet.Find(id));
            }
            catch (Exception ex)
            {
                return new RequestResponse<TEntity>(ex);
            }
        }

        public RequestResponse<TEntity> GetByID(string id, string includes = "")
        {
            try
            {
                return new RequestResponse<TEntity>(dbSet.Find(id));
            }
            catch (Exception ex)
            {
                return new RequestResponse<TEntity>(ex);
            }
        }


        public RequestResponse<TEntity> Insert(TEntity entity, bool SaveChanges = false)
        {
            try
            {
                dbSet.Add(entity);
                return new RequestResponse<TEntity>(entity);
            }
            catch (Exception ex)
            {
                return new RequestResponse<TEntity>(ex);
            }
        }

        public RequestResponse<TEntity> InsertRange(ICollection<TEntity> entity, bool SaveChanges = false)
        {
            try
            {
                dbSet.AddRange(entity);
                return new RequestResponse<TEntity>(entity);
            }
            catch (Exception ex)
            {
                return new RequestResponse<TEntity>(ex);
            }
        }

        public RequestResponse<TEntity> Update(TEntity entityToUpdate, bool SaveChanges = false)
        {
            try
            {
                dbSet.Update(entityToUpdate);
                return new RequestResponse<TEntity>(entityToUpdate);
            }
            catch (Exception ex)
            {
                return new RequestResponse<TEntity>(ex);
            }
        }

        public RequestResponse<TEntity> UpdateRange(ICollection<TEntity> entityToUpdate, bool SaveChanges = false)
        {
            try
            {
                dbSet.UpdateRange(entityToUpdate);
                return new RequestResponse<TEntity>(entityToUpdate);
            }
            catch (Exception ex)
            {
                return new RequestResponse<TEntity>(ex);
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
