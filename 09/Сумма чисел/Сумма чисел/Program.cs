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
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Введите число.");
                int n = int.Parse(Console.ReadLine());
                sum = sum + n;
                Console.WriteLine("Сумма чисел равна - " + sum);
                Console.WriteLine();
            }
        }
    }
}
