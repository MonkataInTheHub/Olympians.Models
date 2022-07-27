using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympians.Models.Interfaces
{
    public interface IOlympicsDatabase
    {
        ICollection<Boxer> Boxers { get; }
        ICollection<Sprinter> Sprinters { get; }
    }
}
