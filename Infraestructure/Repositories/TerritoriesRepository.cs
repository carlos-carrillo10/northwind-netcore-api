using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class TerritoriesRepository : BaseRepository<Territories>, ITerritoriesRepository
    {
        public TerritoriesRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
