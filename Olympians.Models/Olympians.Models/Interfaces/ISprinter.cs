
using Olympians.Models.Interfaces;

namespace Olympians.Models
{
    public interface ISprinter : IOlympian
    {
        
        Dictionary<int, double> PersonalRecords { get; set; }
    }
}