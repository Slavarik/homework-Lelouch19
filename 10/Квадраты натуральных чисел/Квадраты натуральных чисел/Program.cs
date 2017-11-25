using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квадраты_натуральных_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число.");
            int number = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int c = rand.Next(0, number);
            int b = number * number;
            while (true)
            {
                if (c == b || c < b)
                {
                    Console.WriteLine();
                    Console.WriteLine("Квадраты не превосходящие " + number + " : ");
                    Console.WriteLine(c);
                    Console.ReadLine();
                    break;
                }
               
            }
        }
    }
}
