using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modules.Pages.Models;

namespace modules.Data
{
    public class modulesContext : DbContext
    {
        public modulesContext (DbContextOptions<modulesContext> options)
            : base(options)
        {
        }

        public DbSet<modules.Pages.Models.Module> Module { get; set; }
    }
}
