using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 ou \"sair\" para sair");

            Console.WriteLine("---------------");
            Console.WriteLine("Qual deseja executar?");

            switch (Console.ReadLine())
            {
                case "1": Soma(); break;
                case "2": Subtracao(); break;
                case "3": Divisao(); break;
                case "4": Multiplicacao(); break;
                case "0": System.Environment.Exit(0); break;
                case "sair": System.Environment.Exit(0); break;
                default:
                    break;
            }
        }

        static void Soma()
        {
            Console.Clear();
            
            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            //Console.WriteLine("O resultado é: " + (valor1 + valor2));
            //Interpolação
            Console.WriteLine($"O resultado da soma é: {valor1 + valor2}");
            Console.WriteLine("");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da subtração é: {valor1 - valor2}");
            Console.WriteLine("");
            Console.ReadKey();

            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da " +
                $"divisão " +
                $"é: {valor1 / valor2}");
            Console.WriteLine("");
            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"O resultado da " +
                $"multiplicação " +
                $"é: {valor1 * valor2}");
            Console.WriteLine("");
            Console.ReadKey();

            Menu();
        }
    
    }
}
