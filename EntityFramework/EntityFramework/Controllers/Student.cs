using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace EntityFramework.Controllers
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
