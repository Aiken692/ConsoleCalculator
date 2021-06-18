using System;
namespace ConsoleCalculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        public int Calculate(int number1, int number2, string operation)
        {
            if(operation == "/")
            {
                return Divide(number1, number2);
            }
            else if(operation == "+")
            {
                return Add(number1, number2);
            }
            else
            {
                Console.WriteLine("Unknown Operation.");
                return 0;
            }
        }


        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }

        private int Add(int number, int Addend)
        {
            return number + Addend;
        }
    }
}
