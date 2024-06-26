﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BreadpitProject.Models;
using ContactManager.Data;
using Microsoft.AspNetCore.Authorization;

namespace ContactManager.Pages.Sandwiches
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Sandwich> Sandwich { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Sandwich != null)
            {
                Sandwich = await _context.Sandwich.ToListAsync();
            }
        }
    }
}
