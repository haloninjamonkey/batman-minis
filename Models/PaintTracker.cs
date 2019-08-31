using System;
using System.IO;

namespace batman.Models
{
    class PaintTracker
    {
        public string Name { get; set; }

        public PaintTracker(string name)
        {
            Name = name;
        }

        public void Greeting()
        {
            System.Console.WriteLine("What mini(s) did you paint today?");
            string[] path = { Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Batman.txt" };
            string fullPath = Path.Combine(path);
            using (System.IO.StreamWriter file =
             new System.IO.StreamWriter(fullPath, true))
            {
                string latest = Console.ReadLine();
                latest = char.ToUpper(latest[0])+latest.Substring(1).ToLower();
                file.WriteLine(latest);
            }
            System.Console.WriteLine("Awesome, I've updated the file with that.");
            string[] lines = System.IO.File.ReadAllLines(fullPath);

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Here are the minis that you've painted so far!");
            int i = 1;
            foreach (string line in lines)
            {
                Console.WriteLine(i + " " + line);
                i++;
            }
            //Make sure that the user didn't want to add more 
            Console.Write("Did you paint anything else? (y/n) ");
            var answer = System.Console.ReadLine().ToLower();
            if (answer == "y")
            {
                //loop back to allow more items to be added
                Greeting();
            }
            else
            {
                System.Console.WriteLine("Okay, see you!");
            }
        }
    }
}