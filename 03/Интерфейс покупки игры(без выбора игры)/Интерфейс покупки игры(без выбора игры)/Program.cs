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
            Console.WriteLine("Введите свой баланс");
            int balance = int.Parse(Console.ReadLine());
            if (balance >= 2000)
            {
                Console.WriteLine("Поздравляем с покупкой!");
                Console.ReadLine();
                int balance1 = balance - 2000;
                Console.WriteLine("Теперь ваш баланс составляет " + balance1 + " рублей");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("На вашем балансе недостаточно средств");
                Console.ReadLine();
            }
        }
    }
}
