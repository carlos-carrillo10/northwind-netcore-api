using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class OrdersRepository : BaseRepository<Orders>, IOrdersRepository
    {
        public OrdersRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
