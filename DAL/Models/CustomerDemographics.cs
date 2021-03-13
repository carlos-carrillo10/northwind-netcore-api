using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class CustomerDemographics
    {
        [Key]
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    }
}
