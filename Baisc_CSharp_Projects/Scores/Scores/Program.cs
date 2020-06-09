using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"D:\Github Projects\Tech_Academy_Projects\Baisc_CSharp_Projects\Scores\Scores\studentScores.txt";
            double tScore = 0.0;

            Console.WriteLine("\nStudent Score: \n");
            foreach(string line in lines)
            {

            }


            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
