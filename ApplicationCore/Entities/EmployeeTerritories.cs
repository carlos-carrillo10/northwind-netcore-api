using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Entities
{
    [Table("EmployeeTerritories")]
    public partial class EmployeeTerritories : EntityBase
    {
        /// <summary>
        /// Gets or sets the employee id.
        /// </summary>
        [Key, Column(Order = 0)]
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the territory id.
        /// </summary>
        [Key, Column(Order = 2)]
        [Required]
        [StringLength(20)]
        public string TerritoryID { get; set; }

        public virtual Employees Employee { get; set; }

        public virtual Territories Territory { get; set; }
    }
}
