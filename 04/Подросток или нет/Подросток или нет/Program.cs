using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Подросток_или_нет
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой возраст");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10)
            {
                if (age < 20)
                {
                    Console.WriteLine("Поздравляю,ты подросток!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Ваши подростковые годы уже прошли :( ");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Увы,но ты ещё не подросток");
                Console.ReadLine();
            }

        }
    }
}
