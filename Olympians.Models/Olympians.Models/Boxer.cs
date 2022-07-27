using Olympians.Models.Enums;
using Olympians.Models.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Olympians.Models
{
    public class Boxer : Olympian, IOlympian
    {

        public Boxer(string firstName, string lastName, string country, Category boxingCategory, int wins, int losses)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            BoxingCategory = boxingCategory;
            Wins = wins;
            Losses = losses;
        }
        [Range(0, 100)]
        public int Losses { get; set; }

        [Range(0, 100)]
        public int Wins { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string Country { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }

        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; }

        public Category BoxingCategory { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Boxer: {FirstName} {LastName} ");
            sb.AppendLine($"Country: {Country}");
            sb.AppendLine($"Category: {BoxingCategory}");
            sb.AppendLine($"Wins: {Wins}");
            sb.AppendLine($"Losses: {Losses}");
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
