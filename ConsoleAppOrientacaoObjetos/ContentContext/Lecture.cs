using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppOrientacaoObjetos.ContentContext.Enums;

namespace ConsoleAppOrientacaoObjetos.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
        
    }
}
