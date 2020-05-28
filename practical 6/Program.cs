//practical 6: digits to word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical5
{
    class Program
    {
        static Stack<int> numStack = new Stack<int>();
        static Stack<String> digitName = new Stack<String>();
       
        static String getString(int val)
        {
            String str = "";
            int sum=val,digit, remainder;
            for (int i = 0; sum != 0; i--)
            {
                remainder = sum % 10;
                numStack.Push(remainder);
                sum = sum / 10;
                    
            }
                 

                for (int i = numStack.Count; i > 0; i-- )
                {
                    //50556
                        if(i==5)
                        {

                        
                            int tensDigit = numStack.Pop();
                            i--;
                            if (tensDigit == 1)
                            {
                                str += findValue(10 + numStack.Pop());
                                str += " ";
                                
                                str += mapPlaceValue(i);

                               // numStack.Pop();
                            

                            }
                            else
                                { 
                           
                                str += findValue(tensDigit);
                                str += " ";
                            
                                str += mapFaceValue(numStack.Pop());
                                str += " ";
                                if (tensDigit != 0)
                                {
                                    str += mapPlaceValue(i);
                                    str += " ";
                                }
                            

                            }       
                    
                        }                  
                    
                    else if (i != 2)
                        {//100556

                        digit = numStack.Pop();
                        str += mapFaceValue(digit);
                        str += " ";
                        if(digit!=0){
                            str += mapPlaceValue(i);
                            str += " ";
                        }
                    }
                    else
                    { 
                                int tensDigit = numStack.Pop();
                                i--;
                                if (tensDigit == 1)
                                {
                                    str += findValue(10+val%10);
                                    str += " ";
                               
                                    numStack.Pop();
                                    i--; ;

                                }
                                else {

                                    str += findValue(tensDigit);
                                    str += " ";
                                   // i--;
                                    str += mapFaceValue(numStack.Pop());
                                    str += " ";
                                    i--;
                            
                                }             
                
                
                    }
                }

                return str;
          }


        static String findValue(int n) {
            String s = "";
            switch (n)
            {

                case 10: s += "ten";
                    break;
                case 11: s += "eleven";
                    break;
                case 12: s += "twelve";
                    break;
                case 13: s += "thirteen";
                    break;
                case 14: s += "fourteen";
                    break;
                case 15: s += "fifteen";
                    break;
                case 16: s += "sixteen";
                    break;
                case 17: s += "seventeen";
                    break;
                case 18: s += "eighteen";
                    break;
                case 19: s += "nineteen";
                    break;
                case 2: s += "twenty";
                        break;
                case 3: s += "thirty";
                        break;
                case 4: s += "fourty";
                        break;
                case 5: s += "fifty";
                        break;
                case 6: s += "sixty";
                        break;
                case 7: s += "seventy";
                        break;
                case 8: s += "eighty";
                        break;
                case 9: s += "ninety";
                        break;
            }

            return s;
        
        }
        
        // method to find place value of digit
        static String mapFaceValue(int n){
            String s = "";

            switch(n){
                
                    case 0: s+="";
                        break;
                    case 1: s+="one";
                        break;
                    case 2: s+="two";
                        break;
                    case 3: s+="three";
                        break;
                    case 4: s+="four";
                        break;
                    case 5: s+="five";
                        break;
                    case 6: s+="six";
                        break;
                    case 7: s+="seven";
                        break;
                    case 8: s+="eigth";
                        break;
                    case 9: s+="nine";
                        break;        
            }
            return s;
        }

        //method to find face value of a digit
        static String mapPlaceValue(int n)
        {
            String s = "";

            switch (n)
            {
                
                case 1:
                case 2: s += "";
                    break;
                case 3: s += "hundred";
                    break;
                case 4: s += "thousand";
                    break;
                case 5: s += "ten thousand";
                    break;
                case 6: s += "lakh";
                    break;                
                
            }
            return s;
        }


        static String findDigitName(int val){

            String s="";
            switch(val){

                case 0:
                    s+="zero";
                    break;
                case 1:
                    s+="one";
                    break;
                case 2:
                    s+="two";
                    break;
                case 3:
                    s += "three";
                    break;
                case 4:
                    s += "four";
                    break;
                case 5:
                    s += "five";
                    break;
                case 6:
                    s+="six";
                    break;
                case 7:
                    s+="seven";
                    break;
                case 8:
                    s+="eigth";
                    break;
                case 9:
                    s+="nine";
                    break;            
            }

            return s;       
        
        }

        static void pushToStack(int val) {

            int num = val;
            int remainder;


            for (int i = 0; num != 0; i++)
            {

                remainder = num % 10;
                digitName.Push(findDigitName(remainder));
                num = num / 10;


            }
        
        }
        
        static void getNumber(int val){

            pushToStack(val);

            while(digitName.Count!=0){
            
              Console.WriteLine(digitName.Pop());
           }
        }
        
        static void Main(string[] args)
        {
            int num= 222222;
            //displaynumber
            Console.WriteLine("Number" + "  ->  " + num);

            //display each digit in string
            Console.WriteLine("\nDigit in string : " );            
            getNumber(num) ;
           

            //display nueric value to its corresponding string
            Console.WriteLine("\n"+num+"  ->  "+getString(num));



            Console.Read();

        
        }
    }
}
