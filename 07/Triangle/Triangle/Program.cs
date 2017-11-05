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
            Console.WriteLine("Введите длину первой стороны");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второй стороны");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину третьей стороны");
            int c = int.Parse(Console.ReadLine());
            Triangle(a,b,c);
        }
        static void Triangle(int a, int b, int c)
        {
            if(a < (b + c) && b < (a + c) && c < (a + b))
            {
                Console.WriteLine("Такой треугольник может существовать");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Такой треугольник не может существовать");
                Console.ReadLine(); 
            }
        

        }


    }
}
