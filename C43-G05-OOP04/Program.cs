using System;

namespace C43_G05_OOP04
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Sum of two integers: " + calculator.Add(10, 20)); 
            Console.WriteLine("Sum of three integers: " + calculator.Add(10, 20, 30)); 
            Console.WriteLine("Sum of two doubles: " + calculator.Add(5.5, 4.5)); 
        }
    }
}
