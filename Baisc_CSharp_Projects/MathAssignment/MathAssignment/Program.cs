using System;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Multiply an input by 50
            Console.WriteLine("Please input a number to multiply by 50: ");
            string multiplyString = Console.ReadLine();
            int multiplyInt = Convert.ToInt16(multiplyString);
            Console.WriteLine(multiplyInt * 50);
            
            //Add an input by 25
            Console.WriteLine("Please input a number to add 25: ");
            string addString = Console.ReadLine();
            int addInt = Convert.ToInt16(addString);
            Console.WriteLine(multiplyInt + 25);
            
            //Divide an input by 12.5
            Console.WriteLine("Please input a number to divide by 12.5: ");
            string divideString = Console.ReadLine();
            float divideInt = Convert.ToInt32(divideString);
            Console.WriteLine(divideInt / 12.5);

            //Greater than 50
            Console.WriteLine("Please input a number to determine if its greater than 50: ");
            string boolString = Console.ReadLine();
            int boolInt = Convert.ToInt32(boolString);
            int boolFifty = 50;
            Console.WriteLine(boolInt > boolFifty);

            //Remainder of dividing by 7
            Console.WriteLine("Please input a number to determine its remainder divided by 7: ");
            string remainderIntString = Console.ReadLine();
            int remainderInt = Convert.ToInt16(remainderIntString);
            Console.WriteLine(remainderInt % 7);
        }
    }
}
