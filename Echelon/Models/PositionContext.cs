using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Echelon.Models
{
    public class PositionContext :DbContext
    {
        public PositionContext(DbContextOptions<PositionContext> options) : base(options)
        {

        }
    }
}
