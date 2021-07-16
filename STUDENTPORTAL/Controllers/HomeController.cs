using Microsoft.AspNetCore.Mvc;
using STUDENTPORTAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace STUDENTPORTAL.Controllers
{

    public class HomeController : Controller
    {
        FintrakAcademyContext context = new FintrakAcademyContext();
        private object customer;

        public HomeController()
        {
        }

        //TO get customer information

        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
            
        }
        [HttpPost]
        public IActionResult AddCustomer(TblCustomerInformation customer)
        {
            context.TblCustomerInformation.Add(customer);
            context.SaveChanges();
            return View();
        }
        [HttpGet]
    public IActionResult GetCustomerInformation()
        {
            var result = context.TblCustomerInformation.ToList();
            return Json(result);
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string FirstName)
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }

}

