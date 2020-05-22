using System;

namespace BooleanWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop to count up to 10 from 0
            Console.WriteLine("Count up to 10 from 0.");

            int i = -1;

            while (i<10)
            {
                i = i + 1;
                Console.WriteLine(i);
            }

            //Do While loop to count down from 10 to 0
            Console.WriteLine("Count down from 10 to 0.");
            
            int j = 10;
            do
            {
                Console.WriteLine(i);
                i = i - 1;
            }
            while (i != -1);
        }
    }
}
