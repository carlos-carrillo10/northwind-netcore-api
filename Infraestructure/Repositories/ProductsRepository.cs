using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class ProductsRepository : BaseRepository<Products>, IProductsRepository
    {
        public ProductsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
