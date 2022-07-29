using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleBlog_DapperContrib.Models
{
    //Anotação para o Dapper.Contrib saber o nome da tabela.
    //Normalmente ele procura o plural.
    [Table("[Role]")]
    public class Role
    {
        public Role()
            => Users = new List<User>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<User> Users { get; set; }
    }
}
