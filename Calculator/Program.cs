using Calculator.Operators;
using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first num, then press Enter: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, /, *, -), then press Enter: ");
            string op = Console.ReadLine();

            Console.Write("Enter second num, then press Enter: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Addition addition = new Addition();
                    addition.Calculate(firstNum, secondNum);
                    break;
                case "/":
                    Division division = new Division();
                    division.Calculate(firstNum, secondNum);
                    break;
                case "*":
                    Multiplication multiplication = new Multiplication();
                    multiplication.Calculate(firstNum, secondNum);
                    break;
                case "-":
                    Subtraction subtraction = new Subtraction();
                    subtraction.Calculate(firstNum, secondNum);
                    break;
                default:
                    Console.WriteLine("Invaild operator");
                    break;
            }
        }
    }
}