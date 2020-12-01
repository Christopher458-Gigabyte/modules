using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using modules.Data;
using modules.Pages.Models;

namespace modules.Pages.Modules
{
    public class DetailsModel : PageModel
    {
        private readonly modules.Data.modulesContext _context;

        public DetailsModel(modules.Data.modulesContext context)
        {
            _context = context;
        }

        public Module Module { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Module = await _context.Module.FirstOrDefaultAsync(m => m.ID == id);

            if (Module == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
