using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class ConsoleUI : IUI
    {
        public string GetString()
        {
            return Console.ReadLine();
        }
        public ConsoleKey GetKey()
        {
            return Console.ReadKey(intercept: false).Key;
        }
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
