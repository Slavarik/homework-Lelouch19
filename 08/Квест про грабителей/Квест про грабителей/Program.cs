using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Квест_про_грабителей
{
    class Program
    {
        static void Main(string[] args)
        {
            YourApartment();
        }
        static void ShowOptions(string Options)
        {
            Console.WriteLine(Options);
            Thread.Sleep(500);
        }
        static void YourApartment()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Thread.Sleep(500);
            Console.WriteLine("Вот и закончился очередной рабочий день.Вы вернулись домой,но заметили,что дверь взломана.Вы заходите в квартиру и ...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            ShowOptions("1. Идёте в гостиную.");
            ShowOptions("2. Идёте на кухню.");
            ShowOptions("3. Идёте в спальню.");
            ShowOptions("4. Идёте в кабинет.");
            int answer1 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            if (answer1 == 1)
            {
                LivingRoom();
            }
            else if (answer1 == 2)
            {
                Step3();
            }
            else if (answer1 == 3)
            {
                Step4();
            }
            else if (answer1 == 4)
            {
                Step5();
            }
            else
            {

            }
        }
        static void LivingRoom()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Thread.Sleep(500);
            Console.WriteLine("Вы в гостиной.Что делать дальше?");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();

            ShowOptions("1. Проверить спрятанные документы ");
            ShowOptions("2. Проверить открыто ли окно.");
            int answer2 = int.Parse(Console.ReadLine());
            if (answer2 == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Документы на месте!Теперь надо проверить окно.");
                Console.WriteLine("Чтобы проверить окно нажмите ENTER");
                Console.ReadLine();
                Window();
            }
            else if (answer2 == 2)
            {
                Window();
            }
            else
            {
                ShowInvalid();
                while (true)
                {
                    ShowOptions("1. Проверить спрятанные документы ");
                    ShowOptions("2. Проверить открыто ли окно.");
                    int answer3 = int.Parse(Console.ReadLine());
                    if (answer3 == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Thread.Sleep(500);
                        Console.WriteLine();
                        Console.WriteLine("Документы на месте!Теперь надо проверить окно.");
                        Console.WriteLine("Чтобы проверить окно нажмите ENTER");
                        Console.ReadLine();
                        Window();
                    }
                    else if (answer2 == 2)
                    {
                        Window();
                    }
                }
            }
        }
        static void Window()
        {
            if (WindowOpen == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Окно открыто,ура!Теперь выберетесь через него на улицу и вызовите полицию.");
                Console.WriteLine();
                Thread.Sleep(500);
                Console.WriteLine("Ура!Победа!");
                NewGame();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Thread.Sleep(500);
                Console.WriteLine("Окно закрыто.Надо его открыть и выбраться на улицу.");
                Console.WriteLine();
                Thread.Sleep(500);
                Console.WriteLine("Вы спаслись,теперь осталось вызвать полицию!");
                Console.WriteLine();
                Thread.Sleep(500);
                Console.WriteLine("Ура!Победа!");
                Console.ReadLine();
                NewGame();
            }
        }
        static bool WindowOpen = true;
        static void Step3()
        {

        }
        static void Step4()
        {

        }
        static void Step5()
        {

        }
        static void NewGame()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(500);
            Console.WriteLine();
            Console.WriteLine("Хотите начать заново?");
            string answer = Console.ReadLine().ToLower();
            if (answer == "да")
            {
                Console.Clear();
                YourApartment();
            }
            if (answer == "нет")
            {
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Ну и ладно.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine();
                Console.WriteLine("Ответ неясен,но скорее всего вы имели в виду - да.");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void ShowInvalid()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(500);
            Console.WriteLine("Ответ неясен.Нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
