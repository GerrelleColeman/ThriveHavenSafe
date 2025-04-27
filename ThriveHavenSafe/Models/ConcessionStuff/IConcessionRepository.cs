namespace ThriveHavenSafe.Models.ConcessionStuff
{
    public interface IConcessionRepository
    {
        IEnumerable<Concession> Concessions { get; }
    }
}
