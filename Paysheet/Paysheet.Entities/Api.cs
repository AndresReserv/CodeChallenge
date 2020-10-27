/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Entities
{
    /// <summary>
    /// API entity
    /// </summary>
    public class Api
    {
        /// <summary>
        /// Identifier of employee
        /// </summary>
        private int id;

        /// <summary>
        /// Name of employee
        /// </summary>
        private string name;

        /// <summary>
        /// Contract name
        /// </summary>
        private string contractTypeName;

        /// <summary>
        /// Identifier of role
        /// </summary>
        private int roleId;

        /// <summary>
        /// Role name
        /// </summary>
        private string roleName;

        /// <summary>
        /// Role description
        /// </summary>
        private string roleDescription;

        /// <summary>
        /// Value per hour of salary
        /// </summary>
        private double hourlySalary;

        /// <summary>
        /// Value per month of salary
        /// </summary>
        private double monthlySalary;

        /// <summary>
        /// Identifier of employee
        /// </summary>
        public int Id
        {
            get => id;
            set => id = value;
        }

        /// <summary>
        /// Name of employee
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// Contract name
        /// </summary>
        public string ContractTypeName
        {
            get => contractTypeName;
            set => contractTypeName = value;
        }

        /// <summary>
        /// Identifier of contract
        /// </summary>
        public int RoleId
        {
            get => roleId;
            set => roleId = value;
        }

        /// <summary>
        /// Role name
        /// </summary>
        public string RoleName
        {
            get => roleName;
            set => roleName = value;
        }

        /// <summary>
        /// Role description
        /// </summary>
        public string RoleDescription
        {
            get => roleDescription;
            set => roleDescription = value;
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
