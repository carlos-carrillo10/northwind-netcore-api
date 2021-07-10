using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class SortModel<TEntity>
    {
        public Expression<Func<TEntity, object>> SortExpression { get; set; }
        public SortDirection SortDirection { get; set; }
    }

    public enum SortDirection
    {
        None = -1,
        Desc,
        Asc
    }
}
