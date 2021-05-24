using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        //[Key]
        //public string Id { get; set; }
    }

    public interface IEntityBase
    {

    }
}
