using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Examen_Final_Suciu_.Data;
using Examen_Final_Suciu_.Models;

namespace Examen_Final_Suciu_.Pages.Servicii
{
    public class IndexModel : PageModel
    {
        private readonly Examen_Final_Suciu_.Data.Examen_Final_Suciu_Context _context;

        public IndexModel(Examen_Final_Suciu_.Data.Examen_Final_Suciu_Context context)
        {
            _context = context;
        }

        public IList<Salon> Salon { get;set; }

        public async Task OnGetAsync()
        {
            Salon = await _context.Salon.ToListAsync();
        }
    }
}
