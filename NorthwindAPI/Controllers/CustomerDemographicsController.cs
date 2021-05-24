using ApplicationCore.Interfaces.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NorthwindAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerDemographicsController : ControllerBase
    {
        private readonly ICustomerDemographicsRepository _customerDemographicsRepository;
        public CustomerDemographicsController(ICustomerDemographicsRepository customerDemographicsRepository)
        {
            _customerDemographicsRepository = customerDemographicsRepository;
        }

        // GET: api/<CustomerDemographicsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = _customerDemographicsRepository.GetByID("a");
            return Ok(response.Data);
        }

        // GET api/<CustomerDemographicsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomerDemographicsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomerDemographicsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerDemographicsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
