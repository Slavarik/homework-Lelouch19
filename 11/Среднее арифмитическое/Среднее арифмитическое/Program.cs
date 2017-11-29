using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Среднее_арифмитическое
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int sum = 0;
            while(n < 50)
            {
                Random rand = new Random();
                int a = rand.Next(0, 500);
                Console.WriteLine("Число - " + a);
                sum = sum + a;
                n = n + 1;               
            }
            Console.WriteLine("Среднее арифметическое - " + sum/50);
            Console.ReadLine();  
        }
    }
}
