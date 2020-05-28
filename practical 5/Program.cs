//Practical 5 - infix to postfix

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical3
{
    class Program
    {
        //func to get priority of operators
        static int getPriority(char C)
        {
            if (C == '-' || C == '+')
                return 1;
            else if (C == '*' || C == '/')
                return 2;
            else if (C == '^')
                return 3;
            return 0;
        }


        //fun to convert infix to prefix
        static String infixToPrefix(String infix)
        {

            //create stack for operators and operands

            Stack<char> operators = new Stack<char>();
            Stack<String> operands = new Stack<string>();

            for (int i = 0; i < infix.Length; i++)
            {

                if (infix[i] == '(')
                {

                    operators.Push(infix[i]);
                }
                else if (infix[i] == ')')
                {
                    while (operators.Count != 0 && operators.Peek() != '(')
                    {

                        //fetch 2 operands and 1 operator from stack
                        String operand1 = operands.Peek();
                        operands.Pop();

                        String operand2 = operands.Peek();
                        operands.Pop();

                        char op = operators.Peek();
                        operators.Pop();

                        String tempString = op + operand2 + operand1;
                        operands.Push(tempString);
                    }
                    //pop ( bracket from stack
                    operators.Pop();
                }
                else if (Char.IsLetter(infix[i]) || Char.IsDigit(infix[i]))
                {
                    operands.Push("" + infix[i] + "");

                }
                //if given character in not a ( or ) or an operand only possibilty left is of operator
                else
                {

                    while ( operators.Count!=0 && 
                            getPriority(infix[i]) <= getPriority(operators.Peek()) )
                    {

                        String operand1 = operands.Peek();
                        operands.Pop();

                        String operand2 = operands.Peek();
                        operands.Pop();

                        char op = operators.Peek();
                        operators.Pop();

                        String tempString = op + operand2 + operand1;
                        operands.Push(tempString);

                    }

                    operators.Push(infix[i]);

                }


            }
            //once all the char for infix string are checked we pop all the operators and operands from the stack

            while (operators.Count != 0)
            {

                String operand1 = operands.Peek();
                operands.Pop();

                String operand2 = operands.Peek();
                operands.Pop();

                char op = operators.Peek();
                operators.Pop();

                String tempString = op + operand2 + operand1;
                operands.Push(tempString);

            }
            //return prefix string stored in operands stack

            return (operands.Peek());




        }

        static String infixToPostfix(String infix)
        {

            //create stack for operators and operands

            Stack<char> operators = new Stack<char>();
            Stack<String> operands = new Stack<string>();

            for (int i = 0; i < infix.Length; i++)
            {

                if (infix[i] == '(')
                {

                    operators.Push(infix[i]);
                }
                else if (infix[i] == ')')
                {
                    while (operators.Count != 0 && operators.Peek() != '(')
                    {

                        //fetch 2 operands and 1 operator from stack
                        String operand1 = operands.Peek();
                        operands.Pop();

                        String operand2 = operands.Peek();
                        operands.Pop();

                        char op = operators.Peek();
                        operators.Pop();

                        String tempString = op + operand1 + operand2;
                        operands.Push(tempString);
                    }
                    //pop ( bracket from stack
                    operators.Pop();
                }
                else if (Char.IsLetter(infix[i]) || Char.IsDigit(infix[i]))
                {
                    operands.Push("" + infix[i] + "");

                }
                //if given character in not a ( or ) or an operand only possibilty left is of operator
                else
                {

                    while (operators.Count != 0 &&
                            getPriority(infix[i]) <= getPriority(operators.Peek()))
                    {

                        String operand1 = operands.Peek();
                        operands.Pop();

                        String operand2 = operands.Peek();
                        operands.Pop();

                        char op = operators.Peek();
                        operators.Pop();

                        String tempString = op + operand1 + operand2;
                        operands.Push(tempString);

                    }

                    operators.Push(infix[i]);

                }


            }
            //once all the char for infix string are checked we pop all the operators and operands from the stack

            while (operators.Count != 0)
            {

                String operand1 = operands.Peek();
                operands.Pop();

                String operand2 = operands.Peek();
                operands.Pop();

                char op = operators.Peek();
                operators.Pop();

                String tempString = op + operand1 + operand2;
                operands.Push(tempString);

            }
            //return prefix string stored in operands stack

            return (operands.Peek());




        }



        public static void Main()
        {
           
            //infix
            String infix = "(A+B)*(C-D)";
            Console.WriteLine("Infix : " + infix);
            
            //prefix         
            String prefix = infixToPrefix(infix);
            Console.WriteLine("Prefix : "+prefix);
           

           //postfix
             ;
            int len = prefix.Length;
            String infix1 = "";
            
            for (int i = 0; i < len; i++) { 
                
                infix1+=infix[len-1-i];
                
            
            }

            String postfix = infixToPostfix(infix1);
            Console.WriteLine("Postfix : " + postfix);

           
            Console.Read();

        }
    }

}

