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
    public class DeleteModel : PageModel
    {
        private readonly asp_razor_movies.Data.ApplicationDbContext _context;

        public DeleteModel(asp_razor_movies.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Movies Movies { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movies = await _context.Movies.FirstOrDefaultAsync(m => m.ID == id);

            if (Movies == null)
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

            Movies = await _context.Movies.FindAsync(id);

            if (Movies != null)
            {
                _context.Movies.Remove(Movies);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
