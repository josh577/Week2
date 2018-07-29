using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1B
{
    class Multiply2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(num1+ "x" + num2 + "=" + Task1B(num1,num2));
            
        }

        public static int Task1B (int _num1, int _num2)
        {
            return (_num1 * _num2);
        }

    }
}
