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
    public class IndexModel : PageModel
    {
        private readonly modules.Data.modulesContext _context;

        public IndexModel(modules.Data.modulesContext context)
        {
            _context = context;
        }

        public IList<Module> Module { get;set; }

        public async Task OnGetAsync()
        {
            Module = await _context.Module.ToListAsync();
        }
    }
}
