/*pracrical-7   Write a C# code to Convert following currency conversion. Rupees to dollar, frank, euro*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_6
{
    class Program
    {
        static double rupeesToDollar(double INR) {

            return INR / (75.77);
        
        }
        static double rupeesToFranc(double INR)
        {

            return INR / (78.26);

        }
        static double rupeesToEuro(double INR)
        {

            return INR / (83.49);

        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount in INR");
            double INR = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Rupees to dollar " + rupeesToDollar(INR));
            Console.WriteLine("Rupees to franc " + rupeesToFranc(INR));
            Console.WriteLine("Rupees to euro " + rupeesToEuro(INR));
        }
    }
}
