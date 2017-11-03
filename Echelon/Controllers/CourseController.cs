using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Echelon.Data;

namespace Echelon.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository repository;

        public CourseController (ICourseRepository repo)
        {
            repository = repo;
        }
    }
}