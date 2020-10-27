/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
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