using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a number to run a type of Calculation:");
            int run = int.Parse(Console.ReadLine());

            switch(run)
            {
                case 1:
                    Math.Task1Bm(num1,num2);
                    break;

                case 2:
                    Math.Task1Bd(num1, num2);
                    break;

                case 3:
                    Math.Task1Ba(num1, num2);
                    break;

                case 4:
                    Math.Task1Bs(num1, num2);
                    break;

                default:
                    Console.WriteLine("Not a valid input. Try Again.");
                    break;
            }


           
        }
    }

    class Math
    {
        public static void Task1Bm(int _num1, int _num2)
        {

            Console.WriteLine (_num1 * _num2);
        }

        public static void Task1Bd(int _num1, int _num2)
        {

            Console.WriteLine(_num1 / _num2);
        }

        public static void Task1Ba(int _num1, int _num2)
        {

            Console.WriteLine(_num1 + _num2);
        }

        public static void Task1Bs(int _num1, int _num2)
        {

            Console.WriteLine (_num1 - _num2);
        }


    }
}
