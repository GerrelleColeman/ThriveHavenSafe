using Microsoft.EntityFrameworkCore;
using ThriveHavenSafe.Models;
using ThriveHavenSafe.Models.ConcessionStuff;

namespace ThriveHavenSafe.Data
{
    public class ConcessionRepository : IConcessionRepository
    {
        private readonly AppDbContext _context;

        public ConcessionRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Concession> Concessions => _context.Concessions.AsNoTracking();
    }
}
