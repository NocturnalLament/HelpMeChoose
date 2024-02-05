using System;

namespace HelpMeChoose
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Get Random class
            Random rand = new Random();
            //Holds the string to add to the choices 
            string[] decisions = ["Game", "Program"];
            //Gets a big ass array for moar choices.
            string[] choices = new string[1000];
            //Adds a random choice at any point in the array, for addded chaos.
            for (int i = 0; i < 1000; i++)
            {
                choices[i] = decisions[rand.Next(0, 2)];
            }
            //format the answer
            string output = "You should " + choices[rand.Next(0, 1000)];
            //https://www.youtube.com/watch?v=10BBB0k4h9g
            Console.WriteLine(output);
            Console.WriteLine("Press Any Key To Continue...");
            Console.ReadKey();
        }
    }
}