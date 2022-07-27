using Olympians.Models.Interfaces;

namespace Olympians.Models
{
    public interface IBoxer : IOlympian
    {
        string Category { get; set; }
        int Losses { get; set; }
        int Wins { get; set; }
    }
}