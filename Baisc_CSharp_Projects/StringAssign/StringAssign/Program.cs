using System;
using System.Text;

namespace StringAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concatenate three strings
            string a = "This is ";
            string b = "an example ";
            string c = "of string concatenation.";

            string sentance = a + b + c;
            Console.WriteLine(sentance);
            Console.ReadLine();

            //Convert a string to uppercase
            Console.WriteLine(sentance.ToUpper());
            Console.ReadLine();

            
            //Create a string builder and build a paragraph of text, one sentance at a time
            StringBuilder sb = new StringBuilder("Hello, this is an example of StringBuilder(). ");
            sb.AppendFormat("StringBuilder will add new content to a string. \n", 50);
            sb.AppendFormat("This method helps save memory because a new string is not created each time a string needs to be altered.", 150);

            Console.WriteLine(sb);
            Console.ReadLine();
        
        }
    }
}
