using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLIDPrinciples.Employee;

namespace SOLIDPrinciples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee empFTE = new Employee()
            {
                 EmployeeType = empType.FullTime.ToString(),
                TotalHourseWorked = 10
            };
            Employee empPTE = new Employee()
            {
                EmployeeType = empType.PartTime.ToString(),
                TotalHourseWorked = 10
            };
            Employee empContractor = new Employee()
            {
                EmployeeType = empType.Contractor.ToString(),
                TotalHourseWorked = 10
            };

            //OCP principle
            EmployeeFinancesforFTE employeefinancesFTE = new EmployeeFinancesforFTE();
            var totalpayforFTE = employeefinancesFTE.CalculatePay(empFTE);
            Console.WriteLine(totalpayforFTE);

            EmployeeFinancesforPTE employeefinancesPTE = new EmployeeFinancesforPTE();
            var totalpayPTE = employeefinancesPTE.CalculatePay(empPTE);
            Console.WriteLine(totalpayPTE);

            EmployeeFinancesforContractor employeefinancesContractor = new EmployeeFinancesforContractor();
            var totalpayContractor = employeefinancesContractor.CalculatePay(empContractor);
            Console.WriteLine(totalpayContractor);



            Console.ReadLine();
        }
    }
}
