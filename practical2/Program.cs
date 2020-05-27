using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, country;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();

            do
            {
                Console.WriteLine("Enter your name");
                name = Console.ReadLine();

            }
            while (!Regex.IsMatch(name, "^[a-zA-Z]+$"));


            Console.WriteLine("Which country do you belong to?");
            country = Console.ReadLine();

            Console.WriteLine("Hi i am , " + name + " from " + country);

            Console.Read();

        }
    }
}
