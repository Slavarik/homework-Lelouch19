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
            if (a > b)
            {
                comparison(">");
            }
            else if(a == b)
            {
                comparison("=");
            }
            else if(a < b)
            {
                comparison("<");
            }

        }
        static void comparison(string Sign)
        {
            Console.WriteLine(Sign);
            Console.ReadLine();
        }
        


       
        

       
    }
}
