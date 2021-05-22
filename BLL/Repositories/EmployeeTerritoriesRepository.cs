using BLL.IRepositories;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories
{
    public class EmployeeTerritoriesRepository : BaseRepository<EmployeeTerritories>, IEmployeeTerritoriesRepository
    {
        public EmployeeTerritoriesRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
