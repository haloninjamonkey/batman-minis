using System;
using batman.Models;

namespace batman
{
    class Program
    {
        static void Main(string[] args)
        {
            PaintTracker writeTheThings = new PaintTracker("new");
            writeTheThings.Greeting();
        }
    }
}
