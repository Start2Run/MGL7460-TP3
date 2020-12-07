using System;

namespace Business.Contracts
{
    public interface IConsoleWrapper
    {
        ConsoleKeyInfo ReadKey();
        void Write(string data);
    }
}
