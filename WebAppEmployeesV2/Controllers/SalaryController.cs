
using System;
using System.Web.Mvc;
using WebAppEmployeesV2.Interfaces;
using WebAppEmployeesV2.Models;

namespace WebAppEmployeesV2.Controllers
{
    public class SalaryController : Controller
    {
        public SalaryController()
        {

        }

        public ActionResult EstimateSalaryView()
        {
            var model = new Salary();

            return View(model);
        }
    }
}