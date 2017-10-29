using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Opposite(a, b);
         }
        static void Opposite(int a, int b)
        {
            if (a > 0 && b > 0 || a == b )
            {
                Console.WriteLine(" + ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" - ");
                Console.ReadLine();
            }
        }

    }
}
