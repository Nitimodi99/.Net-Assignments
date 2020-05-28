/*Practical 1   Write C# code to display the asterisk pattern as shown below: 
***** 
***** 
***** 
***** 
***** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {


            //call pattern1
            pattern1();

            //call pattern2
            pattern2();

            //call pattern3
            pattern3();

            Console.Read();

        }

        static void pattern1()
        {
            Console.WriteLine("pattern1");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }

        static void pattern2()
        {
            Console.WriteLine("pattern2");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {

                    Console.Write("*");
                }

                Console.WriteLine("");

            }
        }

        static void pattern3()
        {
            Console.WriteLine("pattern3");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("*");
                }

                Console.WriteLine("");

            }
        }
    }


}
