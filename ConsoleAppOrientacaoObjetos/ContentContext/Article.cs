using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppOrientacaoObjetos.NotificationContext;

namespace ConsoleAppOrientacaoObjetos.ContentContext

{
    public class Article : Content
    {
        public Article(string title, string url)
            : base(title,url)
        {
        }
        
    }
}
