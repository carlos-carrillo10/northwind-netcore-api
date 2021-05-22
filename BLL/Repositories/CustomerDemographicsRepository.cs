using BLL.IRepositories;
using DAL.Data;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repositories
{
    public class CustomerDemographicsRepository : BaseRepository<CustomerDemographics>, ICustomerDemographicsRepository
    {
        public CustomerDemographicsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
