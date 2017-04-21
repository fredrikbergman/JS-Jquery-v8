using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JSjQuery.Models;

namespace JsjQuery.Controllers
{
    public class CustomersController : Controller
    {
        


        public IActionResult Index()
        {

            return View(DataManager.GetAllCustomers());
        }
    }
}
