using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentCalculator.Model
{
    public class HourlyEmpSalaryCalculator:EmployeeBaseSalaryCalculator
    {
        public HourlyEmpSalaryCalculator(Employee hourlyEmployee) :base(hourlyEmployee)
        {
        }

        public override double CalculateSalary()
        {
            return BaseEmployee.HourlyRate * BaseEmployee.WorkHours;
        }
    }
}
