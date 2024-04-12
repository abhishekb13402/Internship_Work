using Mini_Project.Data;
using Mini_Project.Models;
using Mini_Project.Models.Interfaces;

namespace Mini_Project.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppConfigDBContext appConfigDBContext;
        public EmployeeService(AppConfigDBContext appConfigDBContext)
        {
            this.appConfigDBContext = appConfigDBContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            var emp =appConfigDBContext.Employees.Add(employee);
            appConfigDBContext.SaveChanges();
            return emp.Entity;
        }

        public List<Employee> GetEmployeeDetails()
        {
            var employees =appConfigDBContext.Employees.ToList();
            return employees;

        }
    }
}
