using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MoviesWebApp.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesWebApp.Data.Models.Movie> Movie { get; set; }
    }
}
