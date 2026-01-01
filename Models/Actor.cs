using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cineverse.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Birth City")]
        [StringLength(100)]
        public string? BirthCity { get; set; }

        [Display(Name = "Birth Country")]
        [StringLength(100)]
        public string? BirthCountry { get; set; }

        [Display(Name = "Height (Inches)")]
        [Range(0, 120)]
        public double Height { get; set; } // In inches

        [DataType(DataType.MultilineText)]
        public string? Biography { get; set; }

        [StringLength(20)]
        public string? Gender { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Net Worth")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal NetWorth { get; set; }

        // Navigation property
        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
