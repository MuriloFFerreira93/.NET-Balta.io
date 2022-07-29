using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleAppOrientacaoObjetos.ContentContext;
using ConsoleAppOrientacaoObjetos.ContentContext.Enums;

namespace ConsoleAppOrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo 1", "chave1"));
            articles.Add(new Article("Artigo 2", "chave2"));
            articles.Add(new Article("Artigo 3", "chave3"));

            //foreach (var article in articles)
            //{
            //    Console.WriteLine(article.Id);
            //    Console.WriteLine(article.Title);
            //    Console.WriteLine(article.Url);
            //}

            var course1 = new Course("Curso1", "chaveC1");
            var course2 = new Course("Curso2", "chaveC2");
            var course3 = new Course("Curso3", "chaveC3");

            var courses = new List<Course>();
            courses.Add(course1);
            courses.Add(course2);
            courses.Add(course3);
    

            var carrer1 = new Carrer("Carreira1", "carreira1url");
            var carrer2 = new Carrer("Carreira2", "carreira2url");
            var carrer3 = new Carrer("Carreira3", "carreira3url");

            var carrers = new List<Carrer>();
            carrers.Add(carrer2);
            carrers.Add(carrer3);
            carrers.Add(carrer1);


            var carreritem1 = new CarrerItem(1, "Comece aqui1", "", null);
            var carreritem2 = new CarrerItem(2, "Comece aqui2", "", course2);
            var carreritem3 = new CarrerItem(3, "Comece aqui3", "", course3);

            carrer1.Items.Add(carreritem1);
            carrer2.Items.Add(carreritem2);
            carrer3.Items.Add(carreritem3);


            foreach (var carrer in carrers)
            {
                Console.WriteLine(carrer.Id);

                foreach (var item in carrer.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course?.Title);
                    Console.WriteLine(item.Course?.Level);

                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

            }
        }
    }
}
