using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Интерфейс_покупки_игры
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите,какую игру хотите приобрести.К примеру GTA5,NFS15,StarCraft");
            string name = (Console.ReadLine());
            Console.WriteLine("Введите свой баланс");
            int balance = int.Parse(Console.ReadLine());
            if (balance >= 1990)
            {
                Console.WriteLine("Поздравляем вас с покупкой " + name + " ! ");
                Console.ReadLine();
                int balance2 = balance - 1990;
                Console.WriteLine("Ваш баланс теперь состовляет " + balance2 + " рублей.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("На вашем счету недостаточно средст :( ");
                Console.ReadLine();
            }
        }
    }
}
