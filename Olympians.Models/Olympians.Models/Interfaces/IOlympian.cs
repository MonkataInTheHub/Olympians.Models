using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympians.Models.Interfaces
{
    public interface IOlympian
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Country { get; set; }
    }
}
