using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatDalalmk.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [Range(0, double.MaxValue)] 
        [DisplayName("Target Salary")]
        public decimal TargetSalary { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        public DateTime? StartDate { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        [DisplayName("Email")]
        public string? Email { get; set; }

        [Phone]
        [DisplayName("Phone Number")]
        public string? PhoneNumber { get; set; }

        [DisplayName("Available")]
        public bool IsAvailable { get; set; }

        [DisplayName("Company")]
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        [Required]
        [DisplayName("Job Title")]
        public int JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }

        [DisplayName("Industry")]
        public int IndustryId { get; set; }
        public Industry? Industry { get; set; }

        [StringLength(500)]
        [DisplayName("Skills")]
        public string? Skills { get; set; }

        [StringLength(200)]
        [DisplayName("LinkedIn Profile")]
        public string? LinkedInProfile { get; set; }

        [Range(0, int.MaxValue)]
        [DisplayName("Years of Experience")]
        public int YearsOfExperience { get; set; }
    }
}
