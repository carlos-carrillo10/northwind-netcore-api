using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    /// <summary>
    /// The territory.
    /// </summary>
    [Table("Territories")]
    public partial class Territories
    {
        /// <summary>
        /// Gets or sets the territory id.
        /// </summary>
        [Key]
        [Required]
        [StringLength(20)]
        public string TerritoryID { get; set; }

        /// <summary>
        /// Gets or sets the territory description.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }

        /// <summary>
        /// Gets or sets the region id.
        /// </summary>
        public int RegionID { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public virtual Region Region { get; set; }

        /// <summary>
        /// Gets or sets the employee territories.
        /// </summary>
        public virtual ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}
