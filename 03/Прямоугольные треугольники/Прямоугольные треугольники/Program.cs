using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Прямоугольные_треугольники
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите длину первой стороны треугольника");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите длину второй стороны треугольника");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Напишите длину третьей стороны треугольника");
            int c = int.Parse(Console.ReadLine());
            double sum1 = a * a;
            double sum2 = b * b;
            double sum3 = c * c;
            //Теорема пифагора - a*a + b*b = c*c
            if (sum1 + sum2 = sum3)
            {
                Console.WriteLine("Треугольник является прямоугольным");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Треугольник не прямоугольный");
                Console.ReadLine();
            }
                 
            
        }
    }
}
