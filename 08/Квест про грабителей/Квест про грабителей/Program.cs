using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квест_про_грабителей
{
    class Program
    {
        static void Main(string[] args)
        {
            Step1();

        }
        static void ShowOptions(string Options)
        {
            Console.WriteLine(Options);
        }
        static void Step1()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Вот и закончился очередной рабочий день.Вы вернулись домой,но заметили,что дверь взломана.Вы заходите в квартиру и ...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            ShowOptions("1. Идёте в гостиную.");
            ShowOptions("2. Идёте на кухню.");
            ShowOptions("3. Идёте в спальню.");
            ShowOptions("4. Идёте в кабинет.");
            Console.ReadLine();
            int answer1 = int.Parse(Console.ReadLine());
            if (answer1 == 1)
            {
                Step2();
            }
            else if(answer1 == 2)
            {

            }
            else if(answer1 == 3)
            {

            }
            else if(answer1 == 4)
            {

            }
            else
            {

            }
        }
        static void Step2()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Вы в гостиной.Что делать дальше?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            ShowOptions("1. Проверить спрятанные документы ");
            ShowOptions("2. Проверить открыто ли окно.");
            int answer2 = int.Parse(Console.ReadLine());
            if(answer2 == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Документы на месте!Теперь надо проверить окно.");
                Console.ReadLine();
                Window();
            }
        }
        static void Window()
        {
            if (WindowOpen == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Окно открыто,ура!Теперь выберетесь через него на улицу и вызовите полицию.");
                Console.WriteLine();
                Console.WriteLine("Ура!Победа!");
            }
        }
        static bool WindowOpen = true;
        
    }

}
