﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacrementPlanner.Data;
using SacrementPlanner.Models;

namespace SacrementPlanner.Pages.Meetings
{
    public class DetailsModel : PageModel
    {
        private readonly SacrementPlanner.Data.SacrementPlannerContext _context;

        public DetailsModel(SacrementPlanner.Data.SacrementPlannerContext context)
        {
            _context = context;
        }

        public Meeting Meeting { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var meeting = await _context.Meeting
                .Include(m => m.Speakers)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);

            if (meeting is not null)
            {
                Meeting = meeting;

                return Page();
            }

            return NotFound();
        }
    }
}
