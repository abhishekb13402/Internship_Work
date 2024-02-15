using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SOLIDPrinciples.Employee;

namespace SOLIDPrinciples
{
    public class EmployeeFinances
    {
//        OCP principle
        public virtual double CalculatePay(Employee emp)
        {
           return 10;
        }
    }

    public class EmployeeFinancesforFTE : EmployeeFinances
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHourseWorked * 10;
        }
    }

    public class EmployeeFinancesforPTE : EmployeeFinances
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHourseWorked * 5;
        }
    }

    public class EmployeeFinancesforContractor : EmployeeFinances
    {
        public override double CalculatePay(Employee emp)
        {
            return emp.TotalHourseWorked * 2;
        }
    }
}
