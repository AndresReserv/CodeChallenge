/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Entities
{
    /// <summary>
    /// Employees entity
    /// </summary>
    public class Employee
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
        /// Type of contract
        /// </summary>
        private ContractType contractType;

        /// <summary>
        /// Employee role
        /// </summary>
        private Role role;

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
        /// Type of contract
        /// </summary>
        public ContractType ContractType
        {
            get => contractType;
            set => contractType = value;
        }

        /// <summary>
        /// Employee role
        /// </summary>
        public Role Role
        {
            get => role;
            set => role = value;
        }
    }
}
