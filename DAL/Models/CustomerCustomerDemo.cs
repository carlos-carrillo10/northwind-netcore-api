using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    /// <summary>
    /// The customer demographic.
    /// </summary>
    [Table("CustomerCustomerDemo")]
    public partial class CustomerCustomerDemo
    {
        /// <summary>
        /// Gets or sets the customer id.
        /// </summary>
        [Key, Column(Order = 0)]
        [Required]
        [StringLength(5, MinimumLength = 5)]
        public string CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the demographic id.
        /// </summary>
        [Key, Column("CustomerTypeID", Order = 1)]
        [Required]
        [StringLength(10, MinimumLength = 10)]
        public string CustomerTypeID { get; set; }

        /// <summary>
        /// Gets or sets the customer.
        /// </summary>
        public virtual Customers Customer { get; set; }

        /// <summary>
        /// Gets or sets the demographic.
        /// </summary>
        public virtual CustomerDemographics Demographic { get; set; }
    }
}
