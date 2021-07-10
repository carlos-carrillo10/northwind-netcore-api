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
    public class EmployeeTerritoriesController : ControllerBase
    {
        private readonly IEmployeeTerritoriesRepository _employeeTerritoriesRepository;
        public EmployeeTerritoriesController(IEmployeeTerritoriesRepository employeeTerritoriesRepository)
        {
            _employeeTerritoriesRepository = employeeTerritoriesRepository;
        }

        // GET: api/<EmployeeTerritoriesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var response = _employeeTerritoriesRepository.GetByID(1);
            //return Ok(response.Data);

            return Ok();
        }

        // GET api/<EmployeeTerritoriesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<EmployeeTerritoriesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<EmployeeTerritoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeeTerritoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
