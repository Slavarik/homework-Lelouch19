using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завистливый_царь
{
    class Program
    {
        static void Main(string[] args)
        {
            int Boyar = 0;
            int TallBoyar = 0;
            while (Boyar < 20)
            {
                Console.WriteLine("Введите рост боярина.");
                int growth = int.Parse(Console.ReadLine());
                if(growth <= 160)
                {
                    Boyar = Boyar + 1;
                }
                else
                {
                    Boyar = Boyar + 1;
                    TallBoyar = TallBoyar + 1;
                }
            }
            Console.WriteLine("Количество бояр,которых стоит наказать - " + TallBoyar);
            Console.ReadLine();
        }
    }
}
