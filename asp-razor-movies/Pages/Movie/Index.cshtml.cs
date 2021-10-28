using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_razor_movies.Data;
using asp_razor_movies.Models;

namespace asp_razor_movies.Pages.Movie
{
    public class IndexModel : PageModel
    {
        private readonly asp_razor_movies.Data.ApplicationDbContext _context;

        public IndexModel(asp_razor_movies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movies> Movies { get;set; }

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.ToListAsync();
        }
    }
}
