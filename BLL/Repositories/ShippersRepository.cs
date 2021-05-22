using BLL.IRepositories;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories
{
    public class ShippersRepository : BaseRepository<Shippers>, IShippersRepository
    {
        public ShippersRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
