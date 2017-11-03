using Echelon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Echelon.Data
{
    public interface ICourseRepository
    {
        IEnumerable<Course> Course { get; }
    }
}
