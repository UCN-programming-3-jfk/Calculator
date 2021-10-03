using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Controller
{
    internal static class CalculationController
    {
        public static float Addition(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static float Subtraction(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static float Multiplication(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public static float Division(float firstNumber, float secondNumber)
        {
            if (secondNumber == 0) { throw new ArgumentException("Unable to divide by zero!"); }
            return firstNumber / secondNumber;
        }
    }
}
