using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatDalalmk.Data;
using RecruitCatDalalmk.Models;

namespace RecruitCatDalalmk.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatDalalmk.Data.RecruitCatDalalmkContext _context;

        public CreateModel(RecruitCatDalalmk.Data.RecruitCatDalalmkContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyId"] = new SelectList(_context.Set<Company>(), "CompanyId", "CompanyName");
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "IndustryId", "IndustryName");
        ViewData["JobTitleId"] = new SelectList(_context.Set<JobTitle>(), "JobTitleId", "Title");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
