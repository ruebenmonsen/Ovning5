using MainProject.Vehicles;
using System;
using System.Collections.Generic;

namespace MainProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new ConsoleUI();
            var handler = new Handler();
            var manager = new Manager(ui, handler);
        }
    }
}