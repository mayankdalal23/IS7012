using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatDalalmk.Models
{
    public class Company
    {
        [DisplayName("Company")]
        public int CompanyId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Company Name")]
        public string? CompanyName { get; set; }

        [StringLength(100)]
        [DisplayName("Position Name")]
        public string? PositionName { get; set; }

        [Range(0, double.MaxValue)] 
        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }

        [Range(0, double.MaxValue)] 
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [StringLength(200)]
        [DisplayName("Location")]
        public string? Location { get; set; }

        [DisplayName("Industry Name")]
        public int IndustryId { get; set; }
        public Industry? Industry { get; set; }

        public ICollection<Candidate>? Candidates { get; set; } = new List<Candidate>();

        [Range(0, int.MaxValue)]
        [DisplayName("Employee Count")]
        public int EmployeeCount { get; set; }

        [DisplayName("Active Status")]
        public bool IsActive { get; set; }

        [Url]
        [StringLength(200)]
        [DisplayName("Website")]
        public string? Website { get; set; }
    }
}
