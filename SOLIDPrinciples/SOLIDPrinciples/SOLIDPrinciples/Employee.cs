using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    public class Employee
    {
        public string EmployeeType { get; set; }
        public double TotalHourseWorked { get; set; }
        public void Save(Employee emp)
        {
            try
            {

            } catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogError(ex.Message);
            }
        }

        public enum empType
        {
            FullTime,
            PartTime,
            Contractor
        }
       
    }
}
