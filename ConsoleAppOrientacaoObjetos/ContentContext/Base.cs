using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppOrientacaoObjetos.NotificationContext;

namespace ConsoleAppOrientacaoObjetos.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

    }
}
