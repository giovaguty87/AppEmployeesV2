using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppEmployeesV2.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public string name { get; set; }
        public string LastName { get; set; }
        public string contractType { get; set; }
        public int roleId { get; set; }
        public string roleDescription { get; set; }
        public string hourlySalary { get; set; }
        public string monthlySalary { get; set; }
        public string totalSalary { get; set; }
    }
}