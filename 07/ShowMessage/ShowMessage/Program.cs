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
            ShowMessage("Привет!", false);
            ShowMessage("Внимание,внимание!", true);
        }
        static void ShowMessage(string message, bool isWarning)
        {
            Console.WriteLine(message);
            Console.ReadLine();
            if (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

        }
    }
}
