using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class RegionRepository : BaseRepository<Region>, IRegionRepository
    {
        public RegionRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
