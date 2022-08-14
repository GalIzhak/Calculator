using Calculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class Division : ICalculate
    {
        public void Calculate(double firstNum, double secondNum)
        {
            Console.WriteLine("The result is: " + firstNum / secondNum);
        }
    }
}
