using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            //Код не работает.Просто наброски :(




            Console.WriteLine("Введите любое слово");
            string Word = Console.ReadLine();
            Console.WriteLine(Word.Length);
            int Long = Word.Length;         
            int n = 0;    //Каждая буква
            int je = 0;   //Буква ж
            while (n < Long)
            {
                char letter = Word[n];
                if (n == 'ж')
                {
                    je = je + 1;
                }
                n = n + 1;

            }
            Thread.Sleep(100);
            Console.WriteLine("Количество букв 'ж' - " + je);
            Console.ReadLine();

        }
    }
}
