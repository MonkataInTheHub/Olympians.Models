using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympians.Models
{
    public class Writer : IWriter
    {
        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }
    }
}
