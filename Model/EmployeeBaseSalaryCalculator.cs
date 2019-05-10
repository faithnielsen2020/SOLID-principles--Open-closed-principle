using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePaymentCalculator.Model
{
    public abstract class EmployeeBaseSalaryCalculator
    {
        protected Employee BaseEmployee { get; private set; }

        public EmployeeBaseSalaryCalculator(Employee emp)
        {
            BaseEmployee = emp;
        }

        public abstract double CalculateSalary();
    }
}
