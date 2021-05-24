using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class EmployeeTerritoriesRepository : BaseRepository<EmployeeTerritories>, IEmployeeTerritoriesRepository
    {
        public EmployeeTerritoriesRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
