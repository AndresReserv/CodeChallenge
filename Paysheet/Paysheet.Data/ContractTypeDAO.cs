/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Paysheet.Data.Context;
    using Paysheet.Entities;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Contract type data access
    /// </summary>
    public class ContractTypeDAO : Base
    {
        /// <summary>
        /// DbContext
        /// </summary>
        private readonly ApplicationDbContext db;

        /// <summary>
        /// Constructor of contract type data access
        /// </summary>
        /// <param name="configuration">Configuration interface</param>
        public ContractTypeDAO(IConfiguration configuration) : base(configuration)
        {
            db = new ApplicationDbContext(_optionsBuilder.Options);
        }

        /// <summary>
        /// Get Method
        /// </summary>
        /// <returns>List of Results</returns>
        public async Task<List<ContractType>> Get()
        {
            try
            {
                return await db.ContractType.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
