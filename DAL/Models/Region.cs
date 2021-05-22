using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    /// <summary>
    /// The region.
    /// </summary>
    [Table("Region")]
    public partial class Region
    {
        /// <summary>
        /// Gets or sets the region id.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionID { get; set; }

        /// <summary>
        /// Gets or sets the region description.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string RegionDescription { get; set; }

        /// <summary>
        /// Gets or sets the territories.
        /// </summary>
        public virtual ICollection<Territories> Territories { get; set; }
    }
}
