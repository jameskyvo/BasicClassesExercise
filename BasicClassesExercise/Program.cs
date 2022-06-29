using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassesExerfcise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ford = new Car();
            ford.Make = "Ford";
            ford.Model = "F150";
            ford.Year = 1999;
            ford.PrintInfo();

            Console.ReadLine();
        }
    }
}
