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
    public class TerritoriesController : ControllerBase
    {
        private readonly ITerritoriesRepository _territoriesRepository;
        public TerritoriesController(ITerritoriesRepository territoriesRepository)
        {
            _territoriesRepository = territoriesRepository;
        }

        // GET: api/<TerritoriesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var response = _territoriesRepository.GetByID("01581");
            //return Ok(response.Data);
            return Ok();
        }

        // GET api/<TerritoriesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TerritoriesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TerritoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TerritoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
