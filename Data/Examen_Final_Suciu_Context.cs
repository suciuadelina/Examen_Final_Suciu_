using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Examen_Final_Suciu_.Models;

namespace Examen_Final_Suciu_.Data
{
    public class Examen_Final_Suciu_Context : DbContext
    {
        public Examen_Final_Suciu_Context (DbContextOptions<Examen_Final_Suciu_Context> options)
            : base(options)
        {
        }

        public DbSet<Examen_Final_Suciu_.Models.Salon> Salon { get; set; }
    }
}
