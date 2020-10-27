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
    public class CalculateSalaryMonthly
    {
        /// <summary>
        /// Gets employee salary per month
        /// </summary>
        /// <returns></returns>
        public virtual double GetEmployeeSalary(EmployeeSalary employee)
        {
            try
            {
                double salary = 0;
                salary = employee.Role.MonthlySalary * 12;
                return salary;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
