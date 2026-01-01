using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cineverse.Models
{
    public class Character
    {
        public int Id { get; set; } 
        
        [Display(Name = "Movie")]
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie? Movie { get; set; }

        [Display(Name = "Actor")]
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public Actor? Actor { get; set; }

        [Required]
        [Display(Name = "Character Name")]
        [StringLength(100)]
        public string CharacterName { get; set; } = string.Empty;
        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Pay { get; set; }
        
        [Display(Name = "Screen Time")]
        public TimeSpan Screentime { get; set; } // Duration
    }
}
