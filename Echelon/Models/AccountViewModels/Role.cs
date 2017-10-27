using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Echelon.Models.AccountViewModels
{
    public class Role
    {
        public string Name { get; set; }

        public Role(string _name)
        {
            Name = _name;
        }

        public static Role[] GetRole()
        {
            Role student = new Role("Student");
            Role teacher = new Role("Teacher");
            Role admin = new Role("Administrator");
            return new Role[] { student, teacher, admin };
        }
    }
}
