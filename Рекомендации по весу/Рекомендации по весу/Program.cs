using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Рекомендации_по_весу
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой рост");
            int growth = int.Parse(Console.ReadLine());
            int hundred = 100;
            double sum = growth - hundred;
            Console.WriteLine("Напишите свой вес");
            int weight = int.Parse(Console.ReadLine());
            if (sum > weight)
            {
                Console.WriteLine("Вам стоит набрать вес");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Вам стоит похудеть");
                Console.ReadLine();
            }



        }
    }
}
