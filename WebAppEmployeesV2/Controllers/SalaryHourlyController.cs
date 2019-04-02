using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppEmployeesV2.Interfaces;

namespace WebAppEmployeesV2.Factory
{
    public class SalaryHourlyController : ICalculateSalary
    {

        public int calculateSalary()
        {
            var response = 120 * 60000 * 12;

            return response;
        }
    }
}