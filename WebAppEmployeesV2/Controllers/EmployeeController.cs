
using System;
using Newtonsoft.Json;
using System.Net.Http;
using WebAppEmployeesV2.Helpers;
using System.Web.Mvc;
using System.Web.UI;
using WebAppEmployeesV2.Models;
using WebAppEmployeesV2.Factory;

namespace WebAppEmployeesV2.Controllers
{
    public class EmployeeController : Controller
    {
        private Employee EmpModel = new Employee();
        private FactoryController factory = new FactoryController();

        public EmployeeController()
        {

        }

        public ActionResult EmployeeView()
        {
            var model = new Employee();

            return View(model);
        }

        [HttpPost]
        public ActionResult EmployeeView(string EmployeeName, string EmployeeLastName, Employee employee)
        {
            // now user.username has the value that user entered on form

            employee.name = EmployeeName;
            employee.LastName = EmployeeLastName;

            var contract = factory.GetContractType(employee.contractType);

            employee.totalSalary = Convert.ToString(contract.calculateSalary());

            var resp = DatabaseUtilities.SaveInformationEmployee(employee);

            return View(new Employee());
        }

        public T RequestInfoEmployees<T>()
        {

            try
            {
                var requestUri = ConstantsUtils.MainURI;

                using (var client = new HttpClient())
                {
                    var responseMessage = client.GetAsync(requestUri).Result;

                    using (var content = responseMessage.Content)
                    {
                        var responseBody = content.ReadAsStringAsync().Result;
                        return JsonConvert.DeserializeObject<T>(responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                return default(T);
                throw;
            }
        }
    }
}