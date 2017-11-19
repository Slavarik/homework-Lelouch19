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
            int MaximumNumber = 100;
            int TimeSleep = 2000;

			while (true) 
            {
				Console.WriteLine("Запомните число: " + number);
                Thread.Sleep(y);
				Console.Clear();

				Console.WriteLine("Введите запомненное число");
				int guess = int.Parse(Console.ReadLine());
				Console.WriteLine();

				if (guess == number) 
                {
					Console.WriteLine("Вы угадали!");
                    MaximumNumber = MaximumNumber + 200;
                    number = rand.Next(MaximumNumber);
                    if (MaximumNumber == 2100)
                    {
                        TimeSleep = TimeSleep - 100;
                        Thread.Sleep(TimeSleep);
                    }
				}
				else 
                {
					Console.WriteLine("Вы ошиблись ='(");
                    MaximumNumber = MaximumNumber - 100;
                    number = rand.Next(MaximumNumber);
				}
				Thread.Sleep(1000);
				Console.Clear();
			}
		}
	}
}
