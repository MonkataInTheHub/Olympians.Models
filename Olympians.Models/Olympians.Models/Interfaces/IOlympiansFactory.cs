using Olympians.Models.Enums;
using System;
using System.Collections.Generic;

namespace Olympians.Models.Interfaces
{
    public interface IOlympiansFactory
    {
        public Boxer CreateBoxer(string firstName, string lastName, string country, Category boxingCategory, int wins, int losses);

        public Sprinter CreateSprinter(string firstName, string lastName, string country, Dictionary<string, string> prs);
    }
}
