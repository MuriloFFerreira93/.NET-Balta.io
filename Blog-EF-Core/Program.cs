using Blog_EF.Data;
using Blog_EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Blog_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {

//Insere registro (Em memória)
                context.Users.Add(new User
                {
                    Bio = "teste Bio",
                    Email = "teste@email.com",
                    Image = "Link da imagem",
                    Name = "Nome teste",
                    PasswordHash = "1235",
                    Slug = "teste-teste132155"
                });

                context.Users.Add(new User
                {
                    Bio = "teste Bio2",
                    Email = "teste@email.com2",
                    Image = "Link da imagem2",
                    Name = "Nome teste2",
                    PasswordHash = "12352",
                    Slug = "teste-teste132152"
                });

                //Atualiza registro (Em memória)
                var tag = context
                            .Tags
                            .FirstOrDefault(x => x.Id == 1);
                tag.Name = tag.Name + " - Teste Update";
                context.Tags.Add(tag);


//Exclui registro (Em memória)
                var tag2 = context.Tags.FirstOrDefault(x => x.Id == 3);  
                context.Tags.Remove(tag2);


// => Executa a memória no banco
                context.SaveChanges();


//Busca uma lista
                var tags = context
                            .Tags
                            .AsNoTracking()
                            .ToList();

                foreach (var item in tags)
                    Console.WriteLine($"{item.Id} - {item.Name} - {item.Slug}");

                var posts = context
                            .Posts
                            .AsNoTracking()
                            .Include(p => p.Author)
                            .Where(p => p.Author.Id == 1)
                            .OrderByDescending(p => p.LastUpdateDate)
                            .ToList();

                foreach (var item in posts)
                    Console.WriteLine($"{item.Id} - {item.Title} - Author: {item.Author?.Name}");

            }
        }
    }
}
