using Olympians.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympians.Models
{
    public class Olympian : IOlympian
    {
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }
        [StringLength(20, MinimumLength = 2)]
        public string Country { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Sprinter: {FirstName} {LastName} ");
            sb.AppendLine($"Country: {Country}");

            return sb.ToString();
        }
    }
}
