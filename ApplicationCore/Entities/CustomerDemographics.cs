using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationCore.Entities
{
    /// <summary>
    /// The demographic.
    /// </summary>
    [Table("CustomerDemographics")]
    public partial class CustomerDemographics : EntityBase
    {
        /// <summary>
        /// Gets or sets the customer demographic id.
        /// </summary>
        [Required]
        [StringLength(10, MinimumLength = 10)]
        [Key, Column("CustomerTypeID")]
        public string CustomerTypeID { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Column("CustomerDesc")]
        public string CustomerDesc { get; set; }

        /// <summary>
        /// Gets or sets the customer demographics.
        /// </summary>
        public virtual ICollection<CustomerCustomerDemo> CustomerCustomerDemo { get; set; }
    }
}
