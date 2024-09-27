using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatDalalmk.Models
{
    public class JobTitle
    {
        
        public int JobTitleId { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Job Title")]
        public string? Title { get; set; }

        [Range(0, double.MaxValue)] 
        [DisplayName("Minimum Salary")]
        public decimal MinSalary { get; set; }

        [Range(0, double.MaxValue)] 
        [DisplayName("Maximum Salary")]
        public decimal MaxSalary { get; set; }

        
        public ICollection<Candidate>? Candidates { get; set; } = new List<Candidate>();

        
        [StringLength(500)]
        [DisplayName("Description")]
        public string? Description { get; set; } 

        [Range(0, int.MaxValue)]
        [DisplayName("Level")]
        public int Level { get; set; } 

        [DisplayName("Is Remote")]
        public bool IsRemote { get; set; } 
    }
}
