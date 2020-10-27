using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Entities
{
    /// <summary>
    /// Contract types entity
    /// </summary>
    public class ContractType
    {
        /// <summary>
        /// Identifier of contract
        /// </summary>
        private int id;

        /// <summary>
        /// Contract type code
        /// </summary>
        private string contractTypeName;

        /// <summary>
        /// Contract type name
        /// </summary>
        private string name;

        /// <summary>
        /// Value to calculate the annual salary.
        /// </summary>
        private double annualSalary;

        /// <summary>
        /// Identifier of entity
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get => id;
            set => id = value;
        }

        /// <summary>
        /// Contract type code
        /// </summary>
        public string ContractTypeName
        {
            get => contractTypeName;
            set => contractTypeName = value;
        }

        /// <summary>
        /// Contract type name
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }

        /// <summary>
        /// Value to calculate the annual salary.
        /// </summary>
        public double AnnualSalary
        {
            get => annualSalary;
            set => annualSalary = value;
        }
    }
}
