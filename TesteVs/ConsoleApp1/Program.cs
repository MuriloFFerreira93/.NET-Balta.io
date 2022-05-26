using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imprime("Hello World!");
        }

        static void Imprime(string texto)
        {
            Console.WriteLine(texto);
            Console.WriteLine(Calcula(135) > 100);
        }

        static double Calcula(double v1, double v2 = 10) //Atribuir valor torna o parametro opcional
        {
            if (v1 > v2)
                v1 = v1 + 1;

            return v1+v2;
        }
    }
}
