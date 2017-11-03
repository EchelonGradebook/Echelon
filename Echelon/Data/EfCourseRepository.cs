using Echelon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Echelon.Data
{
    public class EfCourseRepository : ICourseRepository
    {
        private CourseDbContext context;
        public EfCourseRepository(CourseDbContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Course> Course => context.Course;
    }
}
