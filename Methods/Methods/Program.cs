using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1A
{
    class Multiply
    {
        static void Main(string[] args)
        {
            MultiplyNums();
        }

        public static void MultiplyNums()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1 + "x" + num2 + "=" + (num1*num2));
            Console.ReadLine();
         }
    }
}
