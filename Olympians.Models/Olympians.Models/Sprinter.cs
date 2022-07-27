using Olympians.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Olympians.Models
{
    public class Sprinter : Olympian, IOlympian
    {
        public Sprinter(string firstName, string lastName, string country, Dictionary<string, string> personalRecords)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            PersonalRecords = personalRecords;
        }
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(25, MinimumLength = 3)]
        public string Country { get; set; }

        public Dictionary<string, string> PersonalRecords { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Sprinter: {FirstName} {LastName} ");
            sb.AppendLine($"Country: {Country}");
            sb.AppendLine($"Records: {String.Join(" ", PersonalRecords)}");
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
