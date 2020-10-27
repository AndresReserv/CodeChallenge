/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Interfaces
{
    using Paysheet.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Salary interface
    /// </summary>
    public interface ISalary
    {
        /// <summary>
        /// Gets a list of employees with their annual salary
        /// </summary>
        /// <returns>List of employees with annual salaries</returns>
        Task<List<EmployeeSalary>> GetSalary();

        /// <summary>
        /// Gets an employee with their annual salary
        /// </summary>
        /// <returns>Employees with annual salary</returns>
        Task<EmployeeSalary> GetSalary(int Id);
    }
}
