//practical 3 and 4 - Convert binary to decimal 
//- Convert decimal to hexadecimal 
//- Convert decimal to binary 
//- Convert decimal to octal

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practical4
{
    class Program
    {
        // Binary to decimal
        static double binToDec(int num) {
            //calculate lenght of int number
           
            double dec=0;
            int val;

            //101011
            for(int i=0;num!=0;i++){

                val = num % 10;
                dec+=Math.Pow(2,i)*val;
                num = num / 10;
            
            }
            return dec;
        }



        //decimal to X (where X = hexadecimal , octa, binary)
        static String decToX(int num, int d)
        {
            int val = num;
            String binary = "";
            while (val >= 1)
            {

                binary += (val % d).ToString();
                val = val / d;

            }

            //invert binary string
            String binaryRev = "";
            int len = binary.Length;
            for (int i = 0; i < len; i++)
            {

                binaryRev += binary[len - 1 - i];
            }
            return binaryRev;

        
        }



        static void Main(string[] args)
        {
            int num = 20;
            Console.WriteLine("convert dec value" + num);

           
            //decimal to binary
            decToX(num, 2);
            Console.WriteLine("binary:" + decToX(num, 2));

            //decimal to octa
            decToX(num, 8);
            Console.WriteLine("octa:" + decToX(num, 8));

            //decimal to hex
            decToX(num, 16);
            Console.WriteLine("hex:" + decToX(num, 16));

            //binary to dec
            num = 101011;
            Console.WriteLine("convert binary value" + num+"to decimal");
            Console.WriteLine("decimal:" +binToDec(num) );
            Console.Read();

            



        }
    }
}
