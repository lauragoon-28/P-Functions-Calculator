using System;

namespace P_Functions_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            developerInformation("Laura Goon", "MIS3013", "April 5, 2021");

            Console.WriteLine("What operation would you like to do? (addition, subtraction, multiplication, or division)");
            string opAnswer = Console.ReadLine();

            Console.WriteLine("Please enter two values");
            Console.Write("Value 1 -> ");
            double val1;
            while (double.TryParse(Console.ReadLine(), out val1) == false)
            {
                Console.WriteLine("Invalid input, Please enter a new value");
                Console.Write("Value 1 -> ");
            }
            Console.WriteLine();
            Console.Write("Value 2 -> ");
            double val2;
            while (double.TryParse(Console.ReadLine(), out val2) == false)
            {
                Console.WriteLine("Invalid input, Please enter a new value");
                Console.Write("Value 2 -> ");
            }
            Console.WriteLine();

            string done = "";
            double currentAnswer = 0;
            while (done != "yes")
            {
                if (opAnswer.ToLower() == "addition")
                {
                    currentAnswer = Add(val1, val2);
                }

                else if (opAnswer.ToLower() == "subtraction")
                {
                    currentAnswer = Subtract(val1, val2);
                }

                else if (opAnswer.ToLower() == "multiplication")
                {
                    currentAnswer = Multiply(val1, val2);
                }

                else if (opAnswer.ToLower() == "division")
                {
                    currentAnswer = Divide(val1, val2);
                }

                else
                {
                    Console.WriteLine("Error!!! The operation you entered isn't valid. goodbye!");
                    return;
                }

                Console.WriteLine($"The answer is {currentAnswer}! Would you like to stop?");
                done = Console.ReadLine();
                if (done == "yes")
                {
                    return;
                }

                Console.WriteLine("Would you like to use the previous answer as your first value? (yes or no)");
                string useFirstValue = Console.ReadLine();
                if (useFirstValue.ToLower() == "yes")
                {
                    Console.WriteLine("What operation would you like to do? (addition, subtraction, multiplication, or division)");
                    opAnswer = Console.ReadLine();

                    Console.WriteLine("Please enter one value");
                    val1 = currentAnswer;
                    Console.Write("Value 2 -> ");
                    while (double.TryParse(Console.ReadLine(), out val2) == false)
                    {
                        Console.WriteLine("Invalid input, Please enter a new value");
                        Console.Write("Value 2 -> ");
                    }
                    Console.WriteLine();
                }
                if (useFirstValue.ToLower() == "no")
                {
                    Console.WriteLine("What operation would you like to do? (addition, subtraction, multiplication, or division)");
                    opAnswer = Console.ReadLine();

                    Console.WriteLine("Please enter two values");
                    Console.Write("Value 1 -> ");
                    while (double.TryParse(Console.ReadLine(), out val1) == false)
                    {
                        Console.WriteLine("Invalid input, Please enter a new value");
                        Console.Write("Value 1 -> ");
                    }
                    Console.WriteLine();
                    Console.Write("Value 2 -> ");
                    while (double.TryParse(Console.ReadLine(), out val2) == false)
                    {
                        Console.WriteLine("Invalid input, Please enter a new value");
                        Console.Write("Value 2 -> ");
                    }
                    Console.WriteLine();
                }
            }

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

        static void developerInformation(string name, string className, string date)
        {
            Console.WriteLine($"Written by {name}, for {className}, on {date}.");
            return;
        }
    }
}
