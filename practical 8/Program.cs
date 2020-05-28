/*Practical 8: Write a C# code to Perform Celsius to Fahrenheit Conversion and Fahrenheit to Celsius conversion. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_7
{
    class Program
    {
        static double celciusToFahrenheit(double c)
        {
            
            return c*9/5+32;

        }
        static double fahrenheitToCelcius(double f)
        {

            return (f-32)*5/9;

        }
        


        static void Main(string[] args)
        {
            Console.WriteLine("Enter in temperature in celcius");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("celcius to fahrenheit:  " + celciusToFahrenheit(c));

            Console.WriteLine("Enter in temperature in fahrenheit");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" fahrenheit to  celcius:  " + fahrenheitToCelcius(f));

        }
    }
}
