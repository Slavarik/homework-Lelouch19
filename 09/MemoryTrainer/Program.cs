using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryTrainer 
{
	class Program 
    {
		static void Main(string[] args) 
        {
			GuessNumber();
		}

		static void GuessNumber() 
        {
			Random rand = new Random();
            int number = rand.Next(100);
            int x = 100;

			while (true) 
            {
				Console.WriteLine("Запомните число: " + number);
                Thread.Sleep(2000);
				Console.Clear();

				Console.WriteLine("Введите запомненное число");
				int guess = int.Parse(Console.ReadLine());
				Console.WriteLine();

				if (guess == number) 
                {
					Console.WriteLine("Вы угадали!");
                    x = x + 200;
                    number = rand.Next(x);
				}
				else 
                {
					Console.WriteLine("Вы ошиблись ='(");
                    x = x - 100;
                    number = rand.Next(x);
				}
				Thread.Sleep(1000);
				Console.Clear();
			}
		}
	}
}
