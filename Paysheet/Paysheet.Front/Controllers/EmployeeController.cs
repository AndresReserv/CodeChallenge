/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Front.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Paysheet.Business;
    using Paysheet.Entities;
    using Paysheet.Interfaces;

    public class EmployeeController : BaseController
    {

        /// <summary>
        /// Interface to manipulate benefits
        /// </summary>
        private ISalary BO;

        /// <summary>
        /// Benefit controller constructor
        /// </summary>
        /// <param name="configuration"></param>
        public EmployeeController(IConfiguration configuration) : base(configuration)
        {
            BO = new SalaryBO(_configuration);
        }

        public async Task<IActionResult> Employee()
        {
            //List<EmployeeSalary> response = await BO.GetSalary();
            //return View(response);
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> JsonListar(int Id)
        {
            if (Id > 0)
            {
                return Json(await BO.GetSalary(Id));
            }
            else if (Id == 0)
            {
                return Json(await BO.GetSalary());
            }
            else {
                return Json("");
            }
        }
    }
}