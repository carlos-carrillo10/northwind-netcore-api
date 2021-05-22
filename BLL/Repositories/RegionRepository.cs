using BLL.IRepositories;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories
{
    public class RegionRepository : BaseRepository<Region>, IRegionRepository
    {
        public RegionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
