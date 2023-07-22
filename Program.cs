using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 0)
            {
                long factorial = CalculateFactorial(number);
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }

        static long CalculateFactorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            return num * CalculateFactorial(num - 1);
        }
    }
    }

