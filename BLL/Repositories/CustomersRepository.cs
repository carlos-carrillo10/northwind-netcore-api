using BLL.IRepositories;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories
{
    public class CustomersRepository : BaseRepository<Customers>, ICustomersRepository
    {
        public CustomersRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
