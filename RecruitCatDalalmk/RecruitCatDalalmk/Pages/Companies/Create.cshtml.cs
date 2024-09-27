using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatDalalmk.Data;
using RecruitCatDalalmk.Models;

namespace RecruitCatDalalmk.Pages.Companies
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
        ViewData["IndustryId"] = new SelectList(_context.Set<Industry>(), "IndustryId", "IndustryName");
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
