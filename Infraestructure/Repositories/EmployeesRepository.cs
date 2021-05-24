using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class EmployeesRepository : BaseRepository<Employees>, IEmployeesRepository
    {
        public EmployeesRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
