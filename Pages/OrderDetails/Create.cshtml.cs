using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BreadpitProject.Models;
using ContactManager.Data;

namespace ContactManager
{
    public class CreateModel : PageModel
    {
        private readonly ContactManager.Data.ApplicationDbContext _context;

        public CreateModel(ContactManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderId");
        ViewData["SandwichId"] = new SelectList(_context.Sandwich, "SandwichId", "SandwichId");
            return Page();
        }

        [BindProperty]
        public OrderDetail OrderDetail { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.OrderDetail == null || OrderDetail == null)
            {
                return Page();
            }

            _context.OrderDetail.Add(OrderDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
