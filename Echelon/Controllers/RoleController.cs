using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Echelon.Models.AccountViewModels;

namespace Echelon.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Register()
        {
            ViewBag.Roles = Role.GetRole();
            return View();
        }
    }
}