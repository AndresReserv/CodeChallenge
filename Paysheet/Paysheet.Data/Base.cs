/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Paysheet.Data.Context;

    /// <summary>
    /// Base data access class
    /// </summary>
    public class Base
    {
        /// <summary>
        /// Configuration interface
        /// </summary>
        protected IConfiguration _configuration;

        protected DbContextOptionsBuilder<ApplicationDbContext> _optionsBuilder;

        /// <summary>
        /// Constructor of base class
        /// </summary>
        /// <param name="configuration">Configuration interface</param>
        public Base(IConfiguration configuration)
        {
            _configuration = configuration;
            _optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("dbConnection"));
        }
    }
}
