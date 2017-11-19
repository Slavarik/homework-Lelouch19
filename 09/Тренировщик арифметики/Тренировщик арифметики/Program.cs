using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы закрыть меня,реши задачку.");
            while (true)
            {
                Random rand = new Random();
                int a = rand.Next(0, 10);
                int b = rand.Next(0, 10);
                int c = rand.Next(0, 10);
                Console.WriteLine("Сколько будет " + a + " + " + b + " + " + c + " ?");
                int answer = int.Parse(Console.ReadLine());
                int sum = a + b + c;
                Console.WriteLine();
                if (answer == sum)
                {
                    Console.WriteLine("Ну ты и Мега-мозг!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Неа.Ну-ка, теперь попробуй решить другую");
                }
            }
        }
    }
}
