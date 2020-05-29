using System;
using System.IO;

namespace ReadAndWriteToLog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string userNum = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\Public\Documents\log.txt", false))//new stream for userNum input with no appending
            {
                file.WriteLine(userNum);
            }
            string printNum = File.ReadAllText(@"C:\Users\Public\Documents\log.txt");//print contents of log.
            Console.WriteLine("The number on file is: " + printNum);
        }
    }
}
