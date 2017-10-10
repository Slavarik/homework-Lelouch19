using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Космическая_программа
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите сколько процентов кислорода в составе воздуха");
            int Oxygen = int.Parse(Console.ReadLine());
            if (Oxygen > 20)
            {
                Console.WriteLine("Напишите среднюю температуру поверхность планеты");
                int t = int.Parse(Console.ReadLine());
                if (t > 15)
                {
                    Console.WriteLine("Поздравляю!Вы нашли пригодную для жизни планету!Скорее летите туда!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("На планете слишком холодно.Придётся остаться на Земле ");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("На планете слишком мало кислорода.Лучше останьтесь дома ;(");
                Console.ReadLine();
            }
        }
    }
}
