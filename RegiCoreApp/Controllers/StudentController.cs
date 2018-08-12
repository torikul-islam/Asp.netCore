using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RegiCoreApp.Contex;
using RegiCoreApp.Models;

namespace RegiCoreApp.Controllers
{
    public class StudentController : Controller
    {
        protected ApplicationDbContex _contex;

        public StudentController(ApplicationDbContex contex)
        {
            this._contex = contex;
        }
        public IActionResult Index()
        {
            return View(_contex.Students.ToList());
        }
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Student student)
        {

            return View();
        }
    }
}