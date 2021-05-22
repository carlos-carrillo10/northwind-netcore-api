using BLL.IRepositories;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories
{
    public class TerritoriesRepository : BaseRepository<Territories>, ITerritoriesRepository
    {
        public TerritoriesRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
