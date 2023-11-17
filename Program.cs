using System;

namespace Calculator
{

    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Enter the desired option");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit");

            Console.WriteLine("----------------------");
            Console.WriteLine("Select a Option: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("First value: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double result = v1 + v2;
            Console.WriteLine($"The result of the sum is {result}");
            Console.ReadKey();
            Menu();

        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("First value: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double result = v1 - v2;
            Console.WriteLine($"The result of the subtraction is {result}");
            Console.ReadKey();
            Menu();

        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("First value: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double result = v1 / v2;
            Console.WriteLine($"The result of the division is {result}");
            Console.ReadKey();
            Menu();

        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("First value: ");
            double v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            double v2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double result = v1 * v2;
            Console.WriteLine($"The result of the multiplication is {result}");
            Console.ReadKey();
            Menu();

        }


    }
}