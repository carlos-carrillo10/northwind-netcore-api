using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response.ResponseModels
{
    public class EmployeesResponseModel : BaseResponseModel
    {
        #region Properties

        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }

        #endregion

        #region Constructors

        public EmployeesResponseModel()
        {

        }

        public EmployeesResponseModel(Employees data)
        {
            EmployeeID = data.EmployeeID;
            FirstName = data.FirstName;
            LastName = data.LastName;
            BirthDate = data.BirthDate;
        }

        #endregion
    }
}
