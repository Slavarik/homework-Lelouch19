using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы глава Коммунистической Партии Советского Союза(КПСС)!От вас зависит судьба не только СССР,но и всего мира!Вторая мировая война окончена,но зреет новая война с США.Сможете ли вы предотвратить её и при этом не остаться проигравшим?Началась Корейская война(1950),что же вы будете делать?");
            Console.ReadLine();
            Console.WriteLine("1.Вступить в войну на стороне КНДР ради спасения союзной страны.");
            Console.WriteLine("2.Поддержать КНДР скрытно.");
            Console.WriteLine("3.Сохранить нейтралитет.");
            int answer1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer1 == 1)
            {
                Console.WriteLine("Проигрыш.США объявили вас агрессором и начали миротворческую миссию,которая привела к атомной войне.");
                Console.ReadLine();
                return;
            }
            else if (answer1 == 2)
            {
                Console.WriteLine("Корейская война закончена.Советская авиация показала,что является лучшей в мире.Но на горизонте появляется НАТО!");
            }
            else if (answer1 == 3)
            {
                Console.WriteLine("Проигрыш.Южная Корея,с помощью США,захватила Северную.Мы лишились союзника и теперь находимся под угрозой уничтожения,из-за атомных ракет,которые США разместили в Корее.");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("1.Подписываем Варшавский договор!");
            Console.WriteLine("2.Игнорируем.");
            int answer2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer2 == 1)
            {
                Console.WriteLine("Отлично!Теперь у нас есть союз с другими коммунистическими странами!Но что же это?Наши разведчики докладывают,что США близки к созданию спутника!");
                Console.ReadLine();
            }
            else if (answer2 == 2)
            {
                Console.WriteLine("Проигрыш.Влияние СССР на остальной мир уменьшилось.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("1.У нас есть дела и поважнее,чем какие-то спутники.");
            Console.WriteLine("2.Немедленно запускаем свой спутник!");
            int answer3 = int.Parse(Console.ReadLine());
            if (answer3 == 1)
            {
                Console.WriteLine("Проигрыш.США становятся лидером в космической сфере.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (answer3 == 2)
            {
                Console.WriteLine("Началачь космическая гонка,в которой мы выигрываем!Слава советским космонаватам и инженерам!Ого,на Кубе началась революция!И коммунисты могут прийти к власти.");
                Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("1.Что это за страна вообще?Лучше мы дальше будем пытаться устроить революцию в более развитых странах!");
            Console.WriteLine("2.Поддержим кубинцев!");
            int answer4 = int.Parse(Console.ReadLine());
            if (answer4 == 1)
            {
                Console.WriteLine("Проигрыш.Восстание на Кубе подавлено и к власти вновь пришёл проамериканский диктатор!Многие страны усомнились в наших действиях.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else if (answer4 == 2)
            {
                Console.WriteLine("Революция прошла успешно!Теперь Куба наш друг и союзник!Но во внутреней политике не всё так гладко,как во внешней.Появился писатель Солженицын,который сеет сомнения в умах советских граждан.");
                Console.ReadLine();
            }
            Console.WriteLine("1.Выслать его из страны за измену!");
            Console.WriteLine("2.Пусть пишет дальше,он нам не страшен.");
            int answer5 = int.Parse(Console.ReadLine());
            if (answer5 == 1)
            {
                Console.WriteLine("Предатель выслан из страны.Но начинается война в Афганистане!");
                Console.ReadLine();
            }


            else if (answer5 == 2)
            {
                Console.WriteLine("Солженицину удаётся поднять народ на восстание!СССР на грани развала!");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine();
            Console.WriteLine("1.Помочь коммунистам прийти к власти.");
            Console.WriteLine("2.Не вступать в войну.Мы и так находимся не в лучшей ситуации...");
            int answer6 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (answer6 == 1)
            {
                Console.WriteLine("Война в Афганистане продолжается.Но в нашей стране стоит напряжённая атмосфера.");
                Console.ReadLine();
            }
            else if (answer6 == 2)
            {
                Console.WriteLine("Проигрыш.Американцы победили в войне и разместили там свои базы.Советский союз объявил войну.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("1.Выйти из войны и состредоточитиь все силы на сохранение СССР!");
            Console.WriteLine("2.Продолжаем войну!");
            int answer7 = int.Parse(Console.ReadLine());
            if (answer7 == 1)
            {
                Console.WriteLine("Победа!Советский союз не распался и продолжил стремится к Коммунистическому миру!");
                Console.ReadLine();
            }
            else if (answer7 == 2)
            {
                Console.WriteLine("Проигрыш.Из-за войны и экономического кризиса СССР не смог больше существовать.Это конец!");
                Console.ReadLine();
                return;
            }

        }
    }
}

