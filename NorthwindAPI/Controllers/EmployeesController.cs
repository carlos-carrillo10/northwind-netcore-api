using ApplicationCore.Entities;
using ApplicationCore.Interfaces.IRepositories;
using ApplicationCore.Models;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Response.ResponseModels;
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
    public class EmployeesController : ControllerBase
    {
        #region Properties

        private readonly IEmployeesRepository _employeesRepository;

        #endregion

        public EmployeesController(IEmployeesRepository employeesRepository)
        {
            _employeesRepository = employeesRepository;
        }

        #region GET

        // GET: api/<EmployeesController>
        [HttpGet]
        public async Task<IActionResult> Get(int page, int length)
        {
            var result = await _employeesRepository.GetPagingResultAsync(page, length, select: x => x,
                sortModels: new List<SortModel<Employees>>
                {
                    new SortModel<Employees>
                    {
                        SortExpression = w =>w.EmployeeID,
                        SortDirection = SortDirection.Asc
                    }
                },
               includes: new string[] { });


            var employees = new PaginationResponse<EmployeesResponseModel>
            {
                HasMore = result.HasMore,
                QuantityPages = result.QuantityPages,
                QuantityPagesFiltered = result.QuantityPagesFiltered,
                Total = result.Total,
                TotalFiltered = result.TotalFiltered,
                Result = result.Result.Select(x => new EmployeesResponseModel(x))
            };

            return Ok(new BaseResponse<PaginationResponse<EmployeesResponseModel>>(success: true, employees).ToJson());
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Forbid();
        }

        #endregion

        #region POST

        // POST api/<EmployeesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            return Forbid();
        }

        #endregion

        #region PUT

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] string value)
        {
            return Forbid();
        }

        #endregion

        #region DELETE

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Forbid();
        }

        #endregion
    }
}
