/// <summary>
/// Developmented By Andrés Casas
/// </summary>

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Paysheet.Front.Controllers
{
    public class BaseController : Controller
    {
        /// <summary>
        /// Global controller variables
        /// </summary>
        protected IConfiguration _configuration;

        /// <summary>
        /// Base controller
        /// </summary>
        /// <param name="configuration">Configuration interface</param>
        public BaseController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}