using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOrientacaoObjetos.ContentContext
{
    public class Carrer : Content
    {
        public int Courses { get; set; }
        public IList<CarrerItem> Items { get; set; }
        //Normal Propertie
        //public int TotalCourses { 
        //    get 
        //    {
        //        return Items.Count;
        //    } 
        //}
        public int TotalCourses => Items.Count;
        // ^Expression Body

        public Carrer(string title, string url)
            : base(title, url)
        {
            Items = new List<CarrerItem>();
        }
    }
}
