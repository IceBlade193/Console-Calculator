using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give 2 numbers.");
            Console.Write("First number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("What do you want to do with them?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Divide (first by second)");
            Console.WriteLine("4. Multiply");

            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Sum();
                    break;
                case 2:
                    Subtract();
                    break;
                case 3:
                    Divide();
                    break;
                case 4:
                    Multiply();
                    break;
            }

            void Sum()
            {
                double result = number1 + number2;

                Console.WriteLine("Sum of " + number1 + " and " + number2 + " is: " + result);
            }
            void Subtract()
            {
                double result = number1 - number2;

                Console.WriteLine("Subtract of " + number1 + " and " + number2 + " is: " + result);
            }
            void Divide()
            {
                double result = number1 / number2;

                Console.WriteLine(number1 + " divided by " + number2 + " gives: " + result);
            }
            void Multiply()
            {
                double result = number1 * number2;

                Console.WriteLine(number1 + " multiplied by " + number2 + " gives: " + result);
            }
        }

        


    }
}
