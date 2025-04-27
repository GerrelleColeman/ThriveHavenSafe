using ThriveHavenSafe.Data;

namespace ThriveHavenSafe.Models.MovieStuff
{
    public interface IShowingRepository
    {

        IEnumerable<Showing> Showings { get; }

        

    }
}
