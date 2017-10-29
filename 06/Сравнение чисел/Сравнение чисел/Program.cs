using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сравнение_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе целое число");
            int b = int.Parse(Console.ReadLine());
            Compare(a, b);
        }
        static void Compare(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(">");
                Console.ReadLine();
            }
            else if (a == b)
            {
                Console.WriteLine("=");
                Console.ReadLine();
            }
            else if (a < b)
            {
                Console.WriteLine("<");
                Console.ReadLine();
            }
        }

    }
}
