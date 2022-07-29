using ConsoleBlog_DapperContrib.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleBlog_DapperContrib.Repositories
{
    public class UserRepository : Repository<User>
    {
        private readonly SqlConnection _connection = Database.Connection;

        public List<User> ReadWithRoles()
        {
            var query = @"
                SELECT
                    [User].*,
                    [Role].*
                FROM
                    [User]
                LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
                LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";


            var users = new List<User>();

            //OneToMany
            var items = _connection.Query<User, Role, User>(
                query,
                (user, role) =>
                {
                    //Verifica se existe id no user para
                    //saber se adiciona um user ou um role no user
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if (usr == null)
                    {
                        usr = user;

                        if (role != null)
                            usr.Roles.Add(role);

                        users.Add(usr);
                    }
                    else
                        usr.Roles.Add(role);

                    return user;
                }, splitOn: "Id"); //spitOn diz o campo onde começa a segunda tabela (role)
            return users;
        }
    }
}
