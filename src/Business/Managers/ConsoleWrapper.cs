﻿using Business.Contracts;
using System;

namespace Business.Managers
{
    public class ConsoleWrapper : IConsoleWrapper
    {
        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey(true);
        }

        public void Write(string data)
        {
            Console.Write(data);
        }
    }
}
