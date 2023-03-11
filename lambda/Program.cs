using System;

namespace LambdaExpressionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Func<double, double, double> add = (x, y) => x + y;
            Console.WriteLine($"The sum of the numbers is: {add(num1, num2)}");

            Func<double, double, double> multiply = (x, y) => x * y;
            Console.WriteLine($"The product of the numbers is: {multiply(num1, num2)}");

            Func<double, double, double> findSmaller = (x, y) =>
            {
                if (x < y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            };
            Console.WriteLine($"The smaller of the two numbers is: {findSmaller(num1, num2)}");
        }
    }
}
