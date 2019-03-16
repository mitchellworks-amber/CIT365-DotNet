using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LDSMoviesWeb.Models
{
    public class LDSMoviesWebContext : DbContext
    {
        public LDSMoviesWebContext (DbContextOptions<LDSMoviesWebContext> options)
            : base(options)
        {
        }

        public DbSet<LDSMoviesWeb.Models.Movie> Movie { get; set; }
    }
}
