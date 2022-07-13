using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppOrientacaoObjetos.ContentContext.Enums;

namespace ConsoleAppOrientacaoObjetos.ContentContext

{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

        public Course(string title, string url)
            : base(title, url)
        {
            Modules = new List<Module>();
        }
    }

}
