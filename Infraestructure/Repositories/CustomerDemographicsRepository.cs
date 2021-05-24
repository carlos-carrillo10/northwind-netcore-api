using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repositories
{
    public class CustomerDemographicsRepository : BaseRepository<CustomerDemographics>, ICustomerDemographicsRepository
    {
        public CustomerDemographicsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
