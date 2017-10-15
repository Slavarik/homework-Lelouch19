using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Целые_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье целое число");
            int c = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine("Наибольшее целое число - " + a);
                    Console.ReadLine();
                }
            }
            if (b >= c)
            {
                if (b >= a)
                {
                    Console.WriteLine("Наибольшее целое число - " + b);
                    Console.ReadLine();
                }
            }
            if (c >= b)
            {
                if (c >= a)
                {
                    Console.WriteLine("Наибольшее целое число - " + c);
                    Console.ReadLine();
                }
            }

        }
    }
}
