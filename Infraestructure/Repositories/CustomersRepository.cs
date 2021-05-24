using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class CustomersRepository : BaseRepository<Customers>, ICustomersRepository
    {
        public CustomersRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
