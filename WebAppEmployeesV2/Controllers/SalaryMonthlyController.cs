using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppEmployeesV2.Interfaces;

namespace WebAppEmployeesV2.Factory
{
    public class SalaryMonthlyController : ICalculateSalary
    {
        public int calculateSalary()
        {
            var response = 800000 * 12;

            return response;
        }
    }
}