using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public virtual ICollection<Customers> Customers{ get; set; }
        public int EmployeeID { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        [ForeignKey("Shippers")]
        public int ShipVia { get; set; }
        public virtual ICollection<Shippers> Shippers { get; set; }
        public Decimal Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }
}
