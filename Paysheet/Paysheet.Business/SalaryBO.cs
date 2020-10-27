/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Business
{
    using Microsoft.Extensions.Configuration;
    using Paysheet.Business.Tools;
    using Paysheet.Data;
    using Paysheet.Entities;
    using Paysheet.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Salaries business object
    /// </summary>
    public class SalaryBO : Base, ISalary
    {
        private ApiDAO apiDAO;
        private ContractTypeDAO ContractTypeDAO;

        /// <summary>
        /// Constructor of class
        /// </summary>
        /// <param name="configuration">Configuration interface</param>
        public SalaryBO(IConfiguration configuration) : base(configuration)
        {
            apiDAO = new ApiDAO(_configuration);
            ContractTypeDAO = new ContractTypeDAO(_configuration);
        }

        /// <summary>
        /// Gets a list of employees with their annual salary
        /// </summary>
        /// <returns>List of employees with annual salaries</returns>
        public async Task<List<EmployeeSalary>> GetSalary()
        {
            try
            {
                List<Api> apis = await apiDAO.Get();

                List <EmployeeSalary> list = GetEmployees(apis);

                return list;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Gets an employee with their annual salary
        /// </summary>
        /// <returns>Employees with annual salary</returns>
        public async Task<EmployeeSalary> GetSalary(int Id)
        {
            try
            {
                Api api = await apiDAO.Get(Id);

                if (api != null)
                {
                    EmployeeSalary employee = GetEmployee(api);
                    return employee;
                }
                else {
                    return null;
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }


        /// <summary>
        /// Gets an employees list with their calculate salaries from an api list
        /// </summary>
        /// <param name="apiList">List of employees api</param>
        /// <returns>List of employees with salaries</returns>
        private List<EmployeeSalary> GetEmployees(List<Api> apiList)
        {
            try
            {
                List<EmployeeSalary> employees = new List<EmployeeSalary>();

                foreach (Api api in apiList)
                {
                    employees.Add(GetEmployee(api));
                }
                return employees;

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Gets an employee with their calculate annual salary from an api list
        /// </summary>
        /// <param name="apiList">Employees api</param>
        /// <returns>An employees with annual salary</returns>
        private EmployeeSalary GetEmployee(Api api)
        {
            try
            {
                Task<ContractType> contractType = GetContractType(api.ContractTypeName);
                EmployeeSalary employee = new EmployeeSalary()
                {
                    Id = api.Id,
                    Name = api.Name,
                    ContractType = contractType.Result,
                    Role = new Role()
                    {
                        Id = api.RoleId,
                        Name = api.RoleName,
                        Description = api.RoleDescription,
                        HourlySalary = api.HourlySalary,
                        MonthlySalary = api.MonthlySalary
                    },

                };

                employee.Salary = GetEmployeesSalaries(employee);
                return employee;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Gets employee salary
        /// </summary>
        /// <returns></returns>
        private double GetEmployeesSalaries(EmployeeSalary employee)
        {
            try
            {
                double salary = 0;

                CalculateSalaryMonthly calculate; ;

                if (employee.ContractType.ContractTypeName == _configuration.GetSection("SalariesSettings").GetSection("Monthly").Value)
                {
                    calculate = new CalculateSalaryMonthly();
                    salary = calculate.GetEmployeeSalary(employee);
                }
                if (employee.ContractType.ContractTypeName == _configuration.GetSection("SalariesSettings").GetSection("Hourly").Value)
                {
                    calculate = new CalculateSalaryHourly();
                    salary = calculate.GetEmployeeSalary(employee);
                }

                return salary;
            }
            catch(Exception)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Gets a contract type entity
        /// </summary>
        /// <param name="contract">Contract type name</param>
        /// <returns>Contract type entity</returns>
        private async Task<ContractType> GetContractType(string contract)
        {
            try
            {
                List<ContractType> contractTypeList = await ContractTypeDAO.Get();
                ContractType contractReturn = new ContractType();
                foreach (ContractType c in contractTypeList)
                {
                    if (c.ContractTypeName == contract)
                    {
                        contractReturn = c;
                    }
                }

                return contractReturn;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
