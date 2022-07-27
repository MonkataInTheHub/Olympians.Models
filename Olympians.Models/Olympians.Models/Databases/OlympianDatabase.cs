using Olympians.Models.Interfaces;

namespace Olympians.Models.Databases
{
    public class OlympianDatabase : IOlympicsDatabase
    {
        public OlympianDatabase()
        {
            Boxers = new List<Boxer>();
            Sprinters = new List<Sprinter>();
        }

        public ICollection<Boxer> Boxers { get; }

        public ICollection<Sprinter> Sprinters { get; }
    }
}
