using System;
using System.Threading;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set..");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++; 
                Console.WriteLine(currentTime);

                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = Char.Parse(data.Substring(data.Length - 1 , 1));
            int time = int.Parse(data.Substring(0, data.Length > 1 ? data.Length - 1 : data.Length));

            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                Console.Clear();
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);

        }

    }
}
