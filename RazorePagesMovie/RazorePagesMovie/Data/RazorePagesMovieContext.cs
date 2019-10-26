using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorePagesMovie.Models
{
    public class RazorePagesMovieContext : DbContext
    {
        public RazorePagesMovieContext (DbContextOptions<RazorePagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorePagesMovie.Models.Movie> Movie { get; set; }
    }
}
