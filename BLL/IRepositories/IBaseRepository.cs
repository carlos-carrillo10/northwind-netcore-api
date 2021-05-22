using Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.IRepositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        RequestResponse Delete(TEntity entityToDelete, bool SaveChanges = false);
        RequestResponse DeleteRange(ICollection<TEntity> entityToDelete, bool SaveChanges = false);
        RequestResponse Delete(int id, bool SaveChanges = false);
        RequestResponse<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includes = "");
        RequestResponse<TEntity> GetByID(int id, string includes = "");
        RequestResponse<TEntity> GetByID(string id, string includes = "");
        RequestResponse<TEntity> Insert(TEntity entity, bool SaveChanges = false);
        RequestResponse<TEntity> InsertRange(ICollection<TEntity> entity, bool SaveChanges = false);
        RequestResponse<TEntity> Update(TEntity entityToUpdate, bool SaveChanges = false);
        RequestResponse<TEntity> UpdateRange(ICollection<TEntity> entityToUpdate, bool SaveChanges = false);
        Task SaveChangesAsync();
    }
}
