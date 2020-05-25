using System;

namespace ClassOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs integer to add 10 and return an integer then print the result to the display.
            Console.WriteLine("Please input an integer to operate on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int newNum = MathOperations.myOpperation(userNum);

            Console.WriteLine("Your integer plus 10 is: " + newNum);
            Console.ReadLine();

            //User inputs decimal to add 10 and return an integer then print the result to the display.
            Console.WriteLine("Please input a decimal to operate on: ");
            decimal userNumFloat = Decimal.Parse(Console.ReadLine());

            int newNumFloat = MathOperations.myOpperation(userNumFloat);

            Console.WriteLine("Your decimal multiplied by 10 is: " + newNumFloat);
            Console.ReadLine();

            //User inputs string, class will recieve string parameter and convert to integer. Class will divide by 10 and return an int.
            Console.WriteLine("Please input a integer to operate on: ");
            int newNumDivide = MathOperations.myOpperation(Console.ReadLine());

            Console.WriteLine("Your integer divided by 10 is: " + newNumDivide);
            Console.ReadLine();
        }
    }
}
