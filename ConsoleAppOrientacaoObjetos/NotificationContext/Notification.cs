﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppOrientacaoObjetos.NotificationContext
{
    public sealed class Notification
    {
        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
    }
}
