using Cineverse.Data;
using Cineverse.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cineverse.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new DashboardViewModel();

            // SQLite Limitation Fix: Perform decimal arithmetic and data sorting in memory (Client-side)
            // Fetching all movies first. For a large real-world DB, we would use a different DB provider (SQL Server/Postgres) 
            // or cast to double in SQL if precision loss is acceptable.
            var movies = await _context.Movies.ToListAsync();
            viewModel.TopFlopMovies = movies
                .OrderByDescending(m => m.Budget - m.Gross)
                .Take(10)
                .ToList();

            // Logic for Top 5 Highest Paid Actors and their roles
            // Also performing client-side sort to ensure decimal values sort correctly if stored as strings in SQLite
            var characters = await _context.Characters
                .Include(c => c.Actor)
                .Include(c => c.Movie)
                .ToListAsync();

            viewModel.TopPaidActors = characters
                .OrderByDescending(c => c.Pay)
                .Take(5)
                .Select(c => new ActorRolePayViewModel
                {
                    ActorName = c.Actor!.Name,
                    CharacterName = c.CharacterName,
                    MovieTitle = c.Movie!.Title,
                    Pay = c.Pay
                })
                .ToList();

            return View(viewModel);
        }
    }
}
