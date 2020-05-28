/*Practical-2 Write C# code to prompt a user to input his/her name and country name and then the output will be shown as an example below: 
Hello Ram from country India!*/

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
