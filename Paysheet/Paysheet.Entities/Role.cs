/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Entities
{
    /// <summary>
    /// Roles entity
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Identifier of role
        /// </summary>
        private int id;

        /// <summary>
        /// Role name
        /// </summary>
        private string name;

        /// <summary>
        /// Role description
        /// </summary>
        private string description;

        /// <summary>
        /// Value per hour of salary
        /// </summary>
        private double hourlySalary;

        /// <summary>
        /// Value per month of salary
        /// </summary>
        private double monthlySalary;

        /// <summary>
        /// Identifier of contract
        /// </summary>
        public int Id
        {
            get => id;
            set => id = value;
        }

        /// <summary>
        /// Role name
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// Role description
        /// </summary>
        public string Description
        {
            get => description;
            set => description = value;
        }

        /// <summary>
        /// Value per hour of salary
        /// </summary>
        public double HourlySalary
        {
            get => hourlySalary;
            set => hourlySalary = value;
        }

        /// <summary>
        /// Value per month of salary
        /// </summary>
        public double MonthlySalary
        {
            get => monthlySalary;
            set => monthlySalary = value;
        }
    }
}
