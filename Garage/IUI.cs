using System;

namespace MainProject
{
    public interface IUI
    {
        void Clear();
        ConsoleKey GetKey();
        string GetString();
        void Print(string message);
    }
}