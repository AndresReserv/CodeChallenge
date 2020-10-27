/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Business.Tools
{
    using Paysheet.Entities;
    using System;

    /// <summary>
    /// Tool canculate salary
    /// </summary>
    public class CalculateSalaryHourly : CalculateSalaryMonthly
    {
        /// <summary>
        /// Gets employee salary per hour
        /// </summary>
        /// <returns></returns>
        public override double GetEmployeeSalary(EmployeeSalary employee)
        {
            try
            {
                double salary = 0;
                salary = employee.ContractType.AnnualSalary * employee.Role.HourlySalary * 12;
                return salary;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
