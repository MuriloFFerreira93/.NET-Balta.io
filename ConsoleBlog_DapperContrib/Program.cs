using System;
using ConsoleBlog_DapperContrib.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace ConsoleBlog_DapperContrib
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = Database.Connection;

            using (var _connection = connection)
            {
                var userRepository = new UserRepository();
                var users = userRepository.ReadWithRoles();

                foreach (var user in users)
                {
                    Console.WriteLine(user.Name);

                    foreach (var role in user.Roles)
                    {
                        Console.WriteLine(" - " + role.Name);
                    }
                }
            }
            //Console.ReadKey();
        }


    }
}
