namespace ThriveHavenSafe.Models.MovieStuff
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> Movies { get; }

        Movie getMovieName(string name);
    }


}
