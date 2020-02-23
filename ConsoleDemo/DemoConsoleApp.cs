using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;

namespace ConsoleDemo
{
    class DemoConsoleApp
    {
        static void Main(string[] args)
        {
            Maths m1 = new Maths();

            Console.WriteLine("Please enter First number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the operation to be performed on the numbers:");

            switch (Console.ReadLine())
            {
                case "Add" :
                    Console.WriteLine("The result of addition is : {0}", m1.Addition(firstNumber, secondNumber));
                    break;
                case "Sub":
                    Console.WriteLine("The result of addition is : {0}", m1.Subtraction(firstNumber, secondNumber));
                    break;
                case "Mul":
                    Console.WriteLine("The result of addition is : {0}", m1.Multiplication(firstNumber, secondNumber));
                    break;
                case "Div":
                    Console.WriteLine("The result of addition is : {0}", m1.Division(firstNumber, secondNumber));
                    break;
                default:
                    Console.WriteLine("The operation isn't implemented, Please specify other operation");
                    break;
            }
        }
    }
}
