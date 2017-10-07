using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Сортировка_по_рейтингу
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя первого игрока");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите рейтинг первого игрока");
            int rating1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите имя второго игрока");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите рейтинг второго игрока");
            int rating2 = int.Parse(Console.ReadLine());
            if (rating1 > rating2)
            {
                Console.WriteLine("Результат сортировки - " + name2 + " " + name1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Результат сортировки - " + name1 + " " + name2);
                Console.ReadLine();
            }
        }
    }
}

