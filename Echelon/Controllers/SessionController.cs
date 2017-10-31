using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Echelon.Controllers
{
    public class SessionController : Controller
    {
        [Authorize]
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Assignments()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            return View();
        }

        public IActionResult Grades()
        {
            return View();
        }
    }
}