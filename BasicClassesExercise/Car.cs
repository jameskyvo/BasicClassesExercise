using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassesExerfcise
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"The vehicle is a {Make} {Model} produced in {Year}.");
        }
    }
}
