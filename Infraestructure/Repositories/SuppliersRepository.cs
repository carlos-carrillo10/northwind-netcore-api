using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class SuppliersRepository : BaseRepository<Suppliers>, ISuppliersRepository
    {
        public SuppliersRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
