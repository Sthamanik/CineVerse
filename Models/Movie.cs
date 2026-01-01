using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cineverse.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1)]
        public string Title { get; set; } = string.Empty;

        public string? Rating { get; set; } // MPAA Rating e.g. PG-13

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Budget { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Gross { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [StringLength(50)]
        public string? Genre { get; set; }

        [Range(1, 1000)]
        [Display(Name = "Runtime (Minutes)")]
        public int Runtime { get; set; } // In minutes

        [DataType(DataType.MultilineText)]
        public string? Summary { get; set; }

        // Navigation property
        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
