using Olympians.Models.Enums;
using Olympians.Models.Interfaces;
using System.Collections.Generic;


namespace Olympians.Models.Factory
{
    public class OlympiansFactory : IOlympiansFactory
    {
        public Boxer CreateBoxer(string firstName, string lastName, string country, Category boxingCategory, int wins, int losses)
        {
            return new Boxer( firstName, lastName, country, boxingCategory, wins, losses);
        }

        public Sprinter CreateSprinter(string firstName, string lastName, string country, Dictionary<string, string> prs)
        {
            return new Sprinter(firstName, lastName, country, prs);     
        }
    }
}
