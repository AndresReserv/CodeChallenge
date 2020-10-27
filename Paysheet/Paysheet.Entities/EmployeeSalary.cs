/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Entities
{
    /// <summary>
    /// Employees salary entity
    /// </summary>
    public class EmployeeSalary : Employee
    {
        /// <summary>
        /// Salary by contract type
        /// </summary>
        private double salary;

        /// <summary>
        /// Salary by contract type
        /// </summary>
        public double Salary
        {
            get => salary;
            set => salary = value;
        }
    }
}
