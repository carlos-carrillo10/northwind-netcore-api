using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Single Discount { get; set; }
    }
}
