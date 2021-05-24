using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class OrderDetailsRepository : BaseRepository<OrderDetails>, IOrderDetailsRepository
    {
        public OrderDetailsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }

}
