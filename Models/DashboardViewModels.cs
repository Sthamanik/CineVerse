using System.Collections.Generic;

namespace Cineverse.Models
{
    public class DashboardViewModel
    {
        public List<Movie> TopFlopMovies { get; set; } = new List<Movie>();
        public List<ActorRolePayViewModel> TopPaidActors { get; set; } = new List<ActorRolePayViewModel>();
    }

    public class ActorRolePayViewModel
    {
        public string ActorName { get; set; } = string.Empty;
        public string CharacterName { get; set; } = string.Empty;
        public string MovieTitle { get; set; } = string.Empty;
        public decimal Pay { get; set; }
    }
}
