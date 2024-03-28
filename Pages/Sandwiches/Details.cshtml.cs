using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BreadpitProject.Models;
using ContactManager.Data;

namespace ContactManager.Pages.Sandwiches
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Sandwich Sandwich { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sandwich == null)
            {
                return NotFound();
            }

            var sandwich = await _context.Sandwich.FirstOrDefaultAsync(m => m.SandwichId == id);
            if (sandwich == null)
            {
                return NotFound();
            }
            else
            {
                Sandwich = sandwich;
            }
            return Page();
        }
    }
}
