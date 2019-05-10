using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentCalculator.Model
{
    public class PartTimeEmpSalaryCalculator:EmployeeBaseSalaryCalculator
    {
        public PartTimeEmpSalaryCalculator(Employee partTimeEmployee):base(partTimeEmployee)
        {
        }

        public override double CalculateSalary()
        {
            double result;
            double percentage;
            percentage = (BaseEmployee.HourlyRate * BaseEmployee.WorkHours) * 0.01;
            result = (BaseEmployee.HourlyRate * BaseEmployee.WorkHours) + percentage;
            return result;
        }
    }
}
