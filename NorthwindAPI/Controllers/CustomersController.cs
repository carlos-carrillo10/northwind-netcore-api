﻿using ApplicationCore.Interfaces.IRepositories;
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
    public class CustomersController : ControllerBase
    {

        private readonly ICustomersRepository _customersRepository;
        public CustomersController(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var response = _customersRepository.GetByID("ALFKI");
            //return Ok(response.Data);
            return Ok();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
