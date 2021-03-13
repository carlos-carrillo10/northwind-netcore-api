using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class CustomerCustomerDemo
    {
        [Key]
        public string CustomerID { get; set; }
        public virtual ICollection<Customers> Customer { get; set; }
        [Key]
        public string CustomerTypeID { get; set; }
        public virtual ICollection<CustomerDemographics> CustomerDemographics { get; set; }
    }
}
