using System;
using Microsoft.Data.SqlClient;
using Dapper;
using Balta_DataAcess.MODELS;

namespace Balta_DataAcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";


//                                                                      USANDO O Microsoft.Data.SqlClient;
////-- Criar Conexão, abrir e fechar:

//        //Conexão com banco, sempre abre e fecha
//            var connection = new SqlConnection(connectionString);
//            connection.Open();
//        //Comandos
//            connection.Close();

//        //Dispose fecha e destroi a conexão. É necessário dar um new SqlConnection() para instanciar novamente
//            connection.Dispose();


//        //Uma alternativa melhor é usar o using que irá dar o dispose no fim
//            using (var connection2 = new SqlConnection(connectionString))
//            {
//                connection2.Open();
//                //Comandos
//            }


////-- Usando a conexão
//            using (var connection3 = new SqlConnection(connectionString))
//            {
//                connection3.Open();

//                using (var command = new SqlCommand())
//                {
//                    command.Connection = connection3;
//                    command.CommandType = System.Data.CommandType.Text;
//                    command.CommandText = "SELECT [Id], [Title] FROM [Category]";
                    
//                //.ExecuteReader para busca.
//                //.ExecuteNonQuery ou scalar para insert/update/delete

//                    using (var reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine
//                                (
//                                    $"{reader.GetGuid(0)}" +
//                                    " - " +
//                                    $" {reader.GetString(1)}"
//                                );
//                        }
//                    } 

//                }
//            }


//                                                                           DAPPER
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";
 
            using (var connection = new SqlConnection(connectionString))
            {
                ListCategories(connection);
                //CreateCategory(connection);
                UpdateCategory(connection);
            }
        }

        static void ListCategories(SqlConnection connection)
        {
            //Executa query atribuindo uma lista(retorno do select) ao objeto category(Tabela do abnco)
            var categories = connection.Query<Category>("SELECT [Id], [Title] FROM [Category]");

            foreach (var item in categories)
            {
                Console.WriteLine
                    ($"{item.Id} - {item.Title}");
            }
        }
        
        static void CreateCategory(SqlConnection connection)
        {
            const string connectionString = "Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";

            var category = new Category();
            category.Id = Guid.NewGuid();
            category.Title = "Amazon aws";
            category.Url = "amazon";
            category.Description = "Categoria destinada a serviços aws";
            category.Order = 8;
            category.Summary = "AWS Cloud";
            category.Featured = false;

        //SQL Injection
        // Nunca concatenar string em comandos. Sempre utilixar parâmetros

            var insertSql = @" 
            INSERT INTO
                [Category]
            VALUES(
                @Id,
                @Title,
                @Url,
                @Summary,
                @Order,
                @Description,
                @Featured)";

        //Executar insert/update/delete com parâmetro protegendo de SQL Injection
            var rows = connection.Execute(insertSql, new
            {
                category.Id,
                category.Title,
                category.Url,
                category.Summary,
                category.Order,
                category.Description,
                category.Featured
            });
            
            Console.WriteLine($"{rows} linhas inseridas");
        }
    
        static void UpdateCategory(SqlConnection connection)
        {
            var updateCategory = @"
                UPDATE 
                    [Category]
                SET
                    [Title] = @title
                WHERE
                    [Id] = @id";

            var rows = connection.Execute(updateCategory, new
            {
                id = new Guid("af3407aa-11ae-4621-a2ef-2028b85507c4"),
                title = "Front-End 2021"
            });

            Console.WriteLine($"{rows} linhas atualizadas");
        }

        static void DeleteCategory(SqlConnection connection)
        {
            var deleteCategory = @"
                DELETE FROM 
                    [Category]
                WHERE 
                    [Id] = @id";

            var rows = connection.Execute(deleteCategory, new
            {
                id = new Guid("guid do item")
            });

            Console.WriteLine($"{rows} linhas excluidas");
        }
    }
}
