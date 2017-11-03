using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Echelon.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Id { get; set; }

    }
}
