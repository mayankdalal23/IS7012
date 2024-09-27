using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatDalalmk.Data;
using RecruitCatDalalmk.Models;

namespace RecruitCatDalalmk.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatDalalmk.Data.RecruitCatDalalmkContext _context;

        public DetailsModel(RecruitCatDalalmk.Data.RecruitCatDalalmkContext context)
        {
            _context = context;
        }

        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.IndustryId == id);
            if (industry == null)
            {
                return NotFound();
            }
            else
            {
                Industry = industry;
            }
            return Page();
        }
    }
}
