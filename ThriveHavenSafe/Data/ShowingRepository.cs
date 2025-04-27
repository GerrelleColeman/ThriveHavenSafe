using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using ThriveHavenSafe.Models;
using ThriveHavenSafe.Models.MovieStuff;

namespace ThriveHavenSafe.Data
{
    public class ShowingRepository : IShowingRepository
    {
        private readonly AppDbContext _context;

        public ShowingRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Showing> Showings => _context.Showings;





    }
}
