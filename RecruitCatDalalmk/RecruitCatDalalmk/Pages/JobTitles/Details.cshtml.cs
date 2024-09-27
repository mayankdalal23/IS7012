using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatDalalmk.Data;
using RecruitCatDalalmk.Models;

namespace RecruitCatDalalmk.Pages.JobTitles
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatDalalmk.Data.RecruitCatDalalmkContext _context;

        public DetailsModel(RecruitCatDalalmk.Data.RecruitCatDalalmkContext context)
        {
            _context = context;
        }

        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.JobTitleId == id);
            if (jobtitle == null)
            {
                return NotFound();
            }
            else
            {
                JobTitle = jobtitle;
            }
            return Page();
        }
    }
}
