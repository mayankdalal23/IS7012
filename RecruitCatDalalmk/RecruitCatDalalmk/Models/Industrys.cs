using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatDalalmk.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Industry Name")]
        public string? IndustryName { get; set; }

        [StringLength(500)]
        [DisplayName("Description")]
        public string? Description { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayName("Number of Companies")]
        public int NumberOfCompanies { get; set; }

        [DisplayName("Is Emerging")]
        public bool IsEmerging { get; set; }

        public ICollection<Candidate>? Candidates { get; set; } = new List<Candidate>();
        public ICollection<Company>? Companies { get; set; } = new List<Company>();

        [DataType(DataType.Date)]
        [DisplayName("Established Date")]
        public DateTime EstablishedDate { get; set; }

        [Range(0, double.MaxValue)] 
        [DisplayName("Average Salary")]
        public decimal AverageSalary { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayName("Employee Count")]
        public int EmployeeCount { get; set; }
    }
}
