using System;

namespace P_Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static double Add(double val1, double val2) 
        {
            double sum = val1 + val2;

            return sum;

            //return val1 + val2;
        }

        static double Subtract(double val1, double val2)
        {
            double difference = val1 - val2;

            return difference;
        }

        static double Multiply(double val1, double val2)
        {
            double product = val1 * val2;

            return product;
        }

        static double Divide(double val1, double val2)
        {
            double quotient = val1 / val2;

            return quotient;
        }

        static string developerInformation(string name, string className, string date)
        {
            return 0;
        }
    }
}
