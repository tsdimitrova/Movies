using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MoviesWebApp.Data;
using MoviesWebApp.Data.Models;

namespace MoviesWebApp
{
    public class IndexModel : PageModel
    {
        private readonly MoviesWebApp.Data.RazorPagesMovieContext _context;

        public IndexModel(MoviesWebApp.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
