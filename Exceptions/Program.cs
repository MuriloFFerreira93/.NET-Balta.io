using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new int[1];

            try
            {
                //foreach (int i in a)
                //{
                //    a[i] = i + 10;
                //    Console.WriteLine(a[i+1].ToString());

                //}

                Cadastrar("");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Argumento nulo!\n" + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Indice não encontrado!\n " + ex.InnerException);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro!\n" + ex.Message);
                throw;
            }
            finally  
            {
                Console.WriteLine("Chegou ao fim! Sempre passa no finally");

                //Exemplo de uso: Fechar um arquivo que foi aberto e deu erro.
                //Exemplo de uso: Verificar se está aberta e fechar a conexao com o banco.
            }
        }

        private static void Cadastrar (string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                //throw new Exception("Nome do cadastro não pode ser vazio!");
                throw new ArgumentNullException("Nome do cadastro não pode ser vazio!");
            }
        }
    }
}
