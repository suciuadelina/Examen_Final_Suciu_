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
    public class DeleteModel : PageModel
    {
        private readonly Examen_Final_Suciu_.Data.Examen_Final_Suciu_Context _context;

        public DeleteModel(Examen_Final_Suciu_.Data.Examen_Final_Suciu_Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Salon Salon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Salon = await _context.Salon.FirstOrDefaultAsync(m => m.ID == id);

            if (Salon == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Salon = await _context.Salon.FindAsync(id);

            if (Salon != null)
            {
                _context.Salon.Remove(Salon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
