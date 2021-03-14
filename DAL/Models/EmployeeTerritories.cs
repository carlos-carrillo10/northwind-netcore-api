using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class EmployeeTerritories
    {
        public int EmployeeID { get; set; }
        public virtual ICollection<Employees> Employees { get; set; }
        public string TerritoryID { get; set; }
        public virtual ICollection<Territories> Territories { get; set; }
    }
}
