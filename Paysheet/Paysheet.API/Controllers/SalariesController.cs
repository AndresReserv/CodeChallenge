/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Paysheet.Business;
    using Paysheet.Entities;
    using Paysheet.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class SalariesController : BaseController
    {
        /// <summary>
        /// Interface to manipulate benefits
        /// </summary>
        private ISalary BO;

        /// <summary>
        /// Benefit controller constructor
        /// </summary>
        /// <param name="configuration"></param>
        public SalariesController(IConfiguration configuration) : base(configuration)
        {
            BO = new SalaryBO(_configuration);
        }

        /// <summary>
        /// Get method
        /// </summary>
        /// <returns>List of employee</returns>
        [HttpGet]
        public async Task<ActionResult<List<EmployeeSalary>>> Get()
        {
            try
            {
                List<EmployeeSalary> response = await BO.GetSalary();
                return StatusCode(200, response);
            }
            catch (Exception)
            {
                return StatusCode(500, _configuration.GetSection("Mensajes").GetSection("Error").Value);
            }
        }

        /// <summary>
        /// Get method by id
        /// </summary>
        /// <returns>An employee</returns>
        [HttpGet("{Id}")]
        public async Task<ActionResult<EmployeeSalary>> Get(int Id)
        {
            try
            {
                EmployeeSalary response = await BO.GetSalary(Id);
                return StatusCode(200, response);
            }
            catch (Exception)
            {
                return StatusCode(500, _configuration.GetSection("Mensajes").GetSection("Error").Value);
            }
        }
    }
}