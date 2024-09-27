using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatDalalmk.Models;

namespace RecruitCatDalalmk.Data
{
    public class RecruitCatDalalmkContext : DbContext
    {
        public RecruitCatDalalmkContext (DbContextOptions<RecruitCatDalalmkContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatDalalmk.Models.Candidate> Candidate { get; set; } = default!;
        public DbSet<RecruitCatDalalmk.Models.Company> Company { get; set; } = default!;
        public DbSet<RecruitCatDalalmk.Models.Industry> Industry { get; set; } = default!;
        public DbSet<RecruitCatDalalmk.Models.JobTitle> JobTitle { get; set; } = default!;
    }
}
