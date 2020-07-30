using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string val1;
            string val2;
            Console.Write("Enter integer: ");
            val1 = Console.ReadLine();
            int a = Convert.ToInt32(val1);
            Console.Write("Enter other integer: ");
            val2 = Console.ReadLine();
            int b = Convert.ToInt32(val1);

            Calculate calculate = new Calculate();
            int c = calculate.Add(a, b);

            Console.WriteLine("Your result is: {0}", c);
            Console.ReadKey(true);


        }
    }
}
