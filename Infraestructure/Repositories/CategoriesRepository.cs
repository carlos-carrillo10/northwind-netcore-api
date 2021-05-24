using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class CategoriesRepository : BaseRepository<Categories>, ICategoriesRepository
    {
        public CategoriesRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
