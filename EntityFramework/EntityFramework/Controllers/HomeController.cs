using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;


namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        private EnrollmentDbContext _context;

        public HomeController(EnrollmentDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult Index(Enrollment enrollment)
        {
            _context.Enrollment.Add(enrollment);
            _context.SaveChanges();

            return RedirectToAction("Details");
        }

        public IActionResult Details()
        {
            IEnumerable<Enrollment> myEnrollments = _context.Enrollment;
            return View(myEnrollments);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_context.Enrollment.FirstOrDefault(r => r.ID == id));
        }

        [HttpPost]
        public IActionResult Update(Enrollment r)
        {
            _context.Update(r);
            _context.SaveChanges();
            return RedirectToAction("Details");
        }

        

    }
}
