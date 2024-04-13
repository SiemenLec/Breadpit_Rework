using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BreadpitProject.Models;
using ContactManager.Data;

namespace ContactManager
{
    public class DetailsModel : PageModel
    {
        private readonly ContactManager.Data.ApplicationDbContext _context;

        public DetailsModel(ContactManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public OrderDetail OrderDetail { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.OrderDetail == null)
            {
                return NotFound();
            }

            var orderdetail = await _context.OrderDetail.FirstOrDefaultAsync(m => m.OrderDetailId == id);
            if (orderdetail == null)
            {
                return NotFound();
            }
            else 
            {
                OrderDetail = orderdetail;
            }
            return Page();
        }
    }
}
