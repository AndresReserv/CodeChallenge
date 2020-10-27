/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.UnitTest
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Paysheet.Business;
    using Paysheet.Entities;
    using Paysheet.Interfaces;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    [TestClass]
    public class uTestEmployee
    {
        private IConfiguration _configuration;
        private ISalary BO;
        private string path;
        
        [TestInitialize]
        public void TestInitialization()
        {
            path = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()) + "/appsettings.test.json";// @"C:\Reserv\CodeChallenge\Paysheet\Paysheet.UnitTest\appsettings.test.json";
            _configuration = InitConfiguration.GetConfiguration(path);
            BO = new SalaryBO(_configuration);
        }

        [TestMethod]
        public void Get_annual_salary_correct()
        {
            Task<EmployeeSalary> employee = BO.GetSalary(1);
            Assert.AreEqual(employee.Result.Salary, 8640000);
        }

        [TestMethod]
        public void Get_annual_salary_incorrect()
        {
            Task<EmployeeSalary> employee = BO.GetSalary(1);
            Assert.AreNotEqual(employee.Result.Salary, 8640011);
        }

        [TestMethod]
        public void Get_correct_employee_one()
        {
            Task<EmployeeSalary> employee = BO.GetSalary(1);
            Assert.AreEqual(employee.Result.Name, "Juan");
        }

        [TestMethod]
        public void Get_incorrect_employee_one()
        {
            Task<EmployeeSalary> employee = BO.GetSalary(5);
            Assert.IsNull(employee.Result);
        }

        [TestMethod]
        public void Get_correct_list_employee()
        {
            Task<List<EmployeeSalary>> employees = BO.GetSalary();
            Assert.IsTrue(employees.Result.Count > 0);
        }
    }
}
