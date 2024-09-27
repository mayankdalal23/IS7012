using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatDalalmk.Data;
using RecruitCatDalalmk.Models;

namespace RecruitCatDalalmk.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatDalalmk.Data.RecruitCatDalalmkContext _context;

        public IndexModel(RecruitCatDalalmk.Data.RecruitCatDalalmkContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.Industry)
                .Include(c => c.JobTitle).ToListAsync();
        }
    }
}
