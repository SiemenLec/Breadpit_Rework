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
    public class IndexModel : PageModel
    {
        private readonly ContactManager.Data.ApplicationDbContext _context;

        public IndexModel(ContactManager.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.OrderDetail != null)
            {
                OrderDetail = await _context.OrderDetail
                .Include(o => o.Order)
                .Include(o => o.Sandwich).ToListAsync();
            }
        }
    }
}
